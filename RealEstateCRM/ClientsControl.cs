using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateCRM
{
    /// <summary>Розділ «Клієнти»: додавання, редагування, видалення і пошук.</summary>
    public partial class ClientsControl : UserControl
    {
        // ID клієнта, обраного в таблиці (0 — нічого не обрано)
        private int selectedId = 0;

        public ClientsControl()
        {
            InitializeComponent();
        }

        private void ClientsControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvClients);
            LoadClients();
        }

        /// <summary>Завантажує клієнтів з урахуванням рядка пошуку.</summary>
        private void LoadClients()
        {
            string sql = "SELECT id, full_name, phone, email, note FROM clients " +
                         "WHERE full_name LIKE @search OR phone LIKE @search " +
                         "ORDER BY full_name";
            dgvClients.DataSource = Db.GetTable(sql, Db.P("@search", "%" + txtSearch.Text.Trim() + "%"));

            UiHelper.SetColumn(dgvClients, "id", "ID", null, 30);
            UiHelper.SetColumn(dgvClients, "full_name", "ПІБ", null, 160);
            UiHelper.SetColumn(dgvClients, "phone", "Телефон", null, 100);
            UiHelper.SetColumn(dgvClients, "email", "Ел. пошта", null, 120);
            UiHelper.SetColumn(dgvClients, "note", "Примітка", null, 120);
            dgvClients.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadClients();
        }

        // Клік по рядку таблиці — переносимо дані клієнта в поля редагування
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvClients.Rows[e.RowIndex];
            selectedId = Db.ToInt(row.Cells["id"].Value);
            txtName.Text = Db.ToStr(row.Cells["full_name"].Value);
            txtPhone.Text = Db.ToStr(row.Cells["phone"].Value);
            txtEmail.Text = Db.ToStr(row.Cells["email"].Value);
            txtNote.Text = Db.ToStr(row.Cells["note"].Value);
            lblSelectedId.Text = "Обрано клієнта ID " + selectedId;
        }

        /// <summary>Перевірка обов'язкових полів.</summary>
        private bool ValidateFields()
        {
            if (txtName.Text.Trim() == "")
            {
                UiHelper.Warning("Введіть ПІБ клієнта.");
                txtName.Focus();
                return false;
            }
            if (txtPhone.Text.Trim() == "")
            {
                UiHelper.Warning("Введіть номер телефону.");
                txtPhone.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() != "" && !txtEmail.Text.Contains("@"))
            {
                UiHelper.Warning("Електронна пошта введена неправильно.");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private List<MySqlParameter> GetParameters()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(Db.P("@name", txtName.Text.Trim()));
            parameters.Add(Db.P("@phone", txtPhone.Text.Trim()));
            parameters.Add(Db.P("@email", txtEmail.Text.Trim()));
            parameters.Add(Db.P("@note", txtNote.Text.Trim()));
            return parameters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = "INSERT INTO clients (full_name, phone, email, note) VALUES (@name, @phone, @email, @note)";
            if (Db.Execute(sql, GetParameters().ToArray()) > 0)
            {
                UiHelper.Info("Клієнта додано.");
                ClearFields();
                LoadClients();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть клієнта в таблиці.");
                return;
            }
            if (!ValidateFields()) return;

            string sql = "UPDATE clients SET full_name = @name, phone = @phone, email = @email, note = @note WHERE id = @id";
            List<MySqlParameter> parameters = GetParameters();
            parameters.Add(Db.P("@id", selectedId));

            if (Db.Execute(sql, parameters.ToArray()) > 0)
            {
                UiHelper.Info("Зміни збережено.");
                ClearFields();
                LoadClients();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть клієнта в таблиці.");
                return;
            }
            if (!UiHelper.Confirm("Видалити клієнта «" + txtName.Text + "»?\nЙого заявки також буде видалено.")) return;

            if (Db.Execute("DELETE FROM clients WHERE id = @id", Db.P("@id", selectedId)) > 0)
            {
                ClearFields();
                LoadClients();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedId = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNote.Clear();
            lblSelectedId.Text = "Новий запис";
            dgvClients.ClearSelection();
        }
    }
}
