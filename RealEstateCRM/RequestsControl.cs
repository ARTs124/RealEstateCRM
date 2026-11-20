using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateCRM
{
    /// <summary>Розділ «Заявки»: вимоги клієнтів до нерухомості.</summary>
    public partial class RequestsControl : UserControl
    {
        private int selectedId = 0;

        public RequestsControl()
        {
            InitializeComponent();
        }

        private void RequestsControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvRequests);
            LoadClientsList();
            LoadRequests();
            ClearFields();
        }

        /// <summary>Заповнює ComboBox клієнтами з бази.</summary>
        private void LoadClientsList()
        {
            cmbClient.DisplayMember = "full_name";   // що бачить користувач
            cmbClient.ValueMember = "id";            // що використовуємо в коді
            cmbClient.DataSource = Db.GetTable("SELECT id, full_name FROM clients ORDER BY full_name");
        }

        private void LoadRequests()
        {
            string sql = "SELECT r.id, r.client_id, c.full_name, r.property_type, r.min_area, r.max_area, " +
                         "r.min_budget, r.max_budget, r.district, r.rooms, r.status " +
                         "FROM requests r JOIN clients c ON c.id = r.client_id " +
                         "ORDER BY r.id DESC";
            dgvRequests.DataSource = Db.GetTable(sql);

            UiHelper.HideColumn(dgvRequests, "client_id");
            UiHelper.SetColumn(dgvRequests, "id", "ID", null, 35);
            UiHelper.SetColumn(dgvRequests, "full_name", "Клієнт", null, 150);
            UiHelper.SetColumn(dgvRequests, "property_type", "Тип", null, 90);
            UiHelper.SetColumn(dgvRequests, "min_area", "Площа від", "N0", 60);
            UiHelper.SetColumn(dgvRequests, "max_area", "Площа до", "N0", 60);
            UiHelper.SetColumn(dgvRequests, "min_budget", "Бюджет від", "N0", 75);
            UiHelper.SetColumn(dgvRequests, "max_budget", "Бюджет до", "N0", 75);
            UiHelper.SetColumn(dgvRequests, "district", "Район", null, 85);
            UiHelper.SetColumn(dgvRequests, "rooms", "Кімнат", null, 50);
            UiHelper.SetColumn(dgvRequests, "status", "Статус", null, 70);
            dgvRequests.ClearSelection();
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvRequests.Rows[e.RowIndex];
            selectedId = Db.ToInt(row.Cells["id"].Value);
            cmbClient.SelectedValue = Db.ToInt(row.Cells["client_id"].Value);
            cmbType.SelectedItem = Db.ToStr(row.Cells["property_type"].Value);
            nudMinArea.Value = Db.ToDecimal(row.Cells["min_area"].Value);
            nudMaxArea.Value = Db.ToDecimal(row.Cells["max_area"].Value);
            nudMinBudget.Value = Db.ToDecimal(row.Cells["min_budget"].Value);
            nudMaxBudget.Value = Db.ToDecimal(row.Cells["max_budget"].Value);
            nudRooms.Value = Db.ToInt(row.Cells["rooms"].Value);
            cmbStatus.SelectedItem = Db.ToStr(row.Cells["status"].Value);

            // NULL у полі району означає «Будь-який» (перший пункт списку)
            string district = Db.ToStr(row.Cells["district"].Value);
            if (district == "")
                cmbDistrict.SelectedIndex = 0;
            else
                cmbDistrict.SelectedItem = district;

            lblSelectedId.Text = "Обрано заявку ID " + selectedId;
        }

        private bool ValidateFields()
        {
            if (cmbClient.SelectedValue == null)
            {
                UiHelper.Warning("Оберіть клієнта. Якщо список порожній — спочатку додайте клієнта.");
                return false;
            }
            if (cmbType.SelectedIndex < 0)
            {
                UiHelper.Warning("Оберіть тип нерухомості.");
                return false;
            }
            if (nudMaxArea.Value > 0 && nudMinArea.Value > nudMaxArea.Value)
            {
                UiHelper.Warning("Мінімальна площа не може бути більшою за максимальну.");
                return false;
            }
            if (nudMaxBudget.Value > 0 && nudMinBudget.Value > nudMaxBudget.Value)
            {
                UiHelper.Warning("Мінімальний бюджет не може бути більшим за максимальний.");
                return false;
            }
            return true;
        }

        private List<MySqlParameter> GetParameters()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(Db.P("@client", cmbClient.SelectedValue));
            parameters.Add(Db.P("@type", cmbType.Text));
            // Значення 0 записуємо як NULL — критерій не важливий
            parameters.Add(Db.P("@minArea", Db.NullIfZero(nudMinArea.Value)));
            parameters.Add(Db.P("@maxArea", Db.NullIfZero(nudMaxArea.Value)));
            parameters.Add(Db.P("@minBudget", Db.NullIfZero(nudMinBudget.Value)));
            parameters.Add(Db.P("@maxBudget", Db.NullIfZero(nudMaxBudget.Value)));
            parameters.Add(Db.P("@rooms", Db.NullIfZero(nudRooms.Value)));
            if (cmbDistrict.SelectedIndex > 0)
                parameters.Add(Db.P("@district", cmbDistrict.Text));
            else
                parameters.Add(Db.P("@district", null));
            parameters.Add(Db.P("@status", cmbStatus.Text));
            return parameters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = "INSERT INTO requests (client_id, property_type, min_area, max_area, min_budget, max_budget, district, rooms, status) " +
                         "VALUES (@client, @type, @minArea, @maxArea, @minBudget, @maxBudget, @district, @rooms, @status)";
            if (Db.Execute(sql, GetParameters().ToArray()) > 0)
            {
                UiHelper.Info("Заявку додано.");
                ClearFields();
                LoadRequests();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть заявку в таблиці.");
                return;
            }
            if (!ValidateFields()) return;

            string sql = "UPDATE requests SET client_id = @client, property_type = @type, min_area = @minArea, " +
                         "max_area = @maxArea, min_budget = @minBudget, max_budget = @maxBudget, " +
                         "district = @district, rooms = @rooms, status = @status WHERE id = @id";
            List<MySqlParameter> parameters = GetParameters();
            parameters.Add(Db.P("@id", selectedId));

            if (Db.Execute(sql, parameters.ToArray()) > 0)
            {
                UiHelper.Info("Зміни збережено.");
                ClearFields();
                LoadRequests();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть заявку в таблиці.");
                return;
            }
            if (!UiHelper.Confirm("Видалити обрану заявку?")) return;

            if (Db.Execute("DELETE FROM requests WHERE id = @id", Db.P("@id", selectedId)) > 0)
            {
                ClearFields();
                LoadRequests();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedId = 0;
            cmbClient.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            nudMinArea.Value = 0;
            nudMaxArea.Value = 0;
            nudMinBudget.Value = 0;
            nudMaxBudget.Value = 0;
            nudRooms.Value = 0;
            cmbDistrict.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            lblSelectedId.Text = "Новий запис";
            dgvRequests.ClearSelection();
        }
    }
}
