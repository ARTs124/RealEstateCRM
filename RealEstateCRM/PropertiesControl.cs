using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateCRM
{
    /// <summary>Розділ «Нерухомість»: каталог об'єктів, фільтри та фотографія (LONGBLOB).</summary>
    public partial class PropertiesControl : UserControl
    {
        private int selectedId = 0;

        // Байти фотографії, яка зараз показана в PictureBox (null — фото немає)
        private byte[] photoBytes = null;

        public PropertiesControl()
        {
            InitializeComponent();
        }

        private void PropertiesControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvProperties);
            cmbFilterType.SelectedIndex = 0;
            cmbFilterDistrict.SelectedIndex = 0;
            LoadProperties();
        }

        /// <summary>Завантажує об'єкти з урахуванням пошуку та фільтрів.</summary>
        private void LoadProperties()
        {
            // Фото не завантажуємо в таблицю, щоб вона працювала швидко
            string sql = "SELECT id, title, property_type, district, address, price, area, rooms, description " +
                         "FROM properties WHERE 1 = 1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            // До запиту додаємо тільки ті умови, які користувач заповнив
            if (txtSearch.Text.Trim() != "")
            {
                sql += " AND (title LIKE @search OR address LIKE @search)";
                parameters.Add(Db.P("@search", "%" + txtSearch.Text.Trim() + "%"));
            }
            if (cmbFilterType.SelectedIndex > 0)
            {
                sql += " AND property_type = @type";
                parameters.Add(Db.P("@type", cmbFilterType.Text));
            }
            if (cmbFilterDistrict.SelectedIndex > 0)
            {
                sql += " AND district = @district";
                parameters.Add(Db.P("@district", cmbFilterDistrict.Text));
            }
            if (nudPriceFrom.Value > 0)
            {
                sql += " AND price >= @priceFrom";
                parameters.Add(Db.P("@priceFrom", nudPriceFrom.Value));
            }
            if (nudPriceTo.Value > 0)
            {
                sql += " AND price <= @priceTo";
                parameters.Add(Db.P("@priceTo", nudPriceTo.Value));
            }
            sql += " ORDER BY id DESC";

            dgvProperties.DataSource = Db.GetTable(sql, parameters.ToArray());

            UiHelper.SetColumn(dgvProperties, "id", "ID", null, 35);
            UiHelper.SetColumn(dgvProperties, "title", "Назва", null, 170);
            UiHelper.SetColumn(dgvProperties, "property_type", "Тип", null, 90);
            UiHelper.SetColumn(dgvProperties, "district", "Район", null, 90);
            UiHelper.SetColumn(dgvProperties, "address", "Адреса", null, 140);
            UiHelper.SetColumn(dgvProperties, "price", "Ціна, $", "N0", 80);
            UiHelper.SetColumn(dgvProperties, "area", "Площа, м²", "N1", 70);
            UiHelper.SetColumn(dgvProperties, "rooms", "Кімнат", null, 50);
            UiHelper.HideColumn(dgvProperties, "description");
            dgvProperties.ClearSelection();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadProperties();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterType.SelectedIndex = 0;
            cmbFilterDistrict.SelectedIndex = 0;
            nudPriceFrom.Value = 0;
            nudPriceTo.Value = 0;
            LoadProperties();
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProperties.Rows[e.RowIndex];
            selectedId = Db.ToInt(row.Cells["id"].Value);
            txtTitle.Text = Db.ToStr(row.Cells["title"].Value);
            cmbType.SelectedItem = Db.ToStr(row.Cells["property_type"].Value);
            cmbDistrict.SelectedItem = Db.ToStr(row.Cells["district"].Value);
            txtAddress.Text = Db.ToStr(row.Cells["address"].Value);
            nudPrice.Value = Db.ToDecimal(row.Cells["price"].Value);
            nudArea.Value = Db.ToDecimal(row.Cells["area"].Value);
            nudRooms.Value = Db.ToInt(row.Cells["rooms"].Value);
            txtDescription.Text = Db.ToStr(row.Cells["description"].Value);
            lblSelectedId.Text = "Обрано об'єкт ID " + selectedId;

            // Фотографію читаємо окремим запитом тільки для обраного об'єкта
            object photo = Db.GetValue("SELECT photo FROM properties WHERE id = @id", Db.P("@id", selectedId));
            photoBytes = photo as byte[];
            ShowPhoto(photoBytes);
        }

        // ---------- Робота з фотографією ----------

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                photoBytes = PrepareImage(openFileDialog.FileName);
                ShowPhoto(photoBytes);
            }
            catch (Exception ex)
            {
                UiHelper.Warning("Не вдалося відкрити зображення: " + ex.Message);
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            photoBytes = null;
            ShowPhoto(null);
        }

        /// <summary>
        /// Зменшує фото до 1024 пікселів і перетворює в JPEG.
        /// Так файл займає мало місця і без проблем зберігається в MySQL.
        /// </summary>
        private byte[] PrepareImage(string fileName)
        {
            using (Image original = Image.FromFile(fileName))
            {
                int maxSize = 1024;
                double scale = Math.Min(1.0, (double)maxSize / Math.Max(original.Width, original.Height));
                int width = (int)(original.Width * scale);
                int height = (int)(original.Height * scale);

                using (Bitmap resized = new Bitmap(original, width, height))
                using (MemoryStream stream = new MemoryStream())
                {
                    resized.Save(stream, ImageFormat.Jpeg);
                    return stream.ToArray();
                }
            }
        }

        /// <summary>Показує фото з масиву байтів у PictureBox.</summary>
        private void ShowPhoto(byte[] bytes)
        {
            if (picPhoto.Image != null)
            {
                picPhoto.Image.Dispose();
                picPhoto.Image = null;
            }
            if (bytes == null || bytes.Length == 0) return;

            using (MemoryStream stream = new MemoryStream(bytes))
            using (Image image = Image.FromStream(stream))
            {
                picPhoto.Image = new Bitmap(image);
            }
        }

        // ---------- Додавання, редагування, видалення ----------

        private bool ValidateFields()
        {
            if (txtTitle.Text.Trim() == "")
            {
                UiHelper.Warning("Введіть назву об'єкта.");
                txtTitle.Focus();
                return false;
            }
            if (cmbType.SelectedIndex < 0)
            {
                UiHelper.Warning("Оберіть тип нерухомості.");
                return false;
            }
            if (cmbDistrict.SelectedIndex < 0)
            {
                UiHelper.Warning("Оберіть район.");
                return false;
            }
            if (nudPrice.Value <= 0 || nudArea.Value <= 0)
            {
                UiHelper.Warning("Ціна та площа мають бути більше нуля.");
                return false;
            }
            return true;
        }

        private List<MySqlParameter> GetParameters()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(Db.P("@title", txtTitle.Text.Trim()));
            parameters.Add(Db.P("@type", cmbType.Text));
            parameters.Add(Db.P("@address", txtAddress.Text.Trim()));
            parameters.Add(Db.P("@district", cmbDistrict.Text));
            parameters.Add(Db.P("@price", nudPrice.Value));
            parameters.Add(Db.P("@area", nudArea.Value));
            parameters.Add(Db.P("@rooms", (int)nudRooms.Value));
            parameters.Add(Db.P("@description", txtDescription.Text.Trim()));
            parameters.Add(Db.P("@photo", photoBytes));   // масив байтів записується в LONGBLOB
            return parameters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = "INSERT INTO properties (title, property_type, address, district, price, area, rooms, description, photo) " +
                         "VALUES (@title, @type, @address, @district, @price, @area, @rooms, @description, @photo)";
            if (Db.Execute(sql, GetParameters().ToArray()) > 0)
            {
                UiHelper.Info("Об'єкт додано.");
                ClearFields();
                LoadProperties();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть об'єкт у таблиці.");
                return;
            }
            if (!ValidateFields()) return;

            string sql = "UPDATE properties SET title = @title, property_type = @type, address = @address, " +
                         "district = @district, price = @price, area = @area, rooms = @rooms, " +
                         "description = @description, photo = @photo WHERE id = @id";
            List<MySqlParameter> parameters = GetParameters();
            parameters.Add(Db.P("@id", selectedId));

            if (Db.Execute(sql, parameters.ToArray()) > 0)
            {
                UiHelper.Info("Зміни збережено.");
                ClearFields();
                LoadProperties();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть об'єкт у таблиці.");
                return;
            }
            if (!UiHelper.Confirm("Видалити об'єкт «" + txtTitle.Text + "»?")) return;

            if (Db.Execute("DELETE FROM properties WHERE id = @id", Db.P("@id", selectedId)) > 0)
            {
                ClearFields();
                LoadProperties();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedId = 0;
            txtTitle.Clear();
            cmbType.SelectedIndex = -1;
            cmbDistrict.SelectedIndex = -1;
            txtAddress.Clear();
            nudPrice.Value = 0;
            nudArea.Value = 0;
            nudRooms.Value = 0;
            txtDescription.Clear();
            photoBytes = null;
            ShowPhoto(null);
            lblSelectedId.Text = "Новий запис";
            dgvProperties.ClearSelection();
        }
    }
}
