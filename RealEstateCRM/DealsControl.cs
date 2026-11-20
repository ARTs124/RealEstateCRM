using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateCRM
{
    /// <summary>Розділ «Угоди»: створення угод і зміна їх етапу (статусу).</summary>
    public partial class DealsControl : UserControl
    {
        private int selectedId = 0;

        public DealsControl()
        {
            InitializeComponent();
        }

        private void DealsControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvDeals);
            LoadLists();
            LoadDeals();
            ClearFields();
        }

        /// <summary>Заповнює списки клієнтів та об'єктів.</summary>
        private void LoadLists()
        {
            cmbClient.DisplayMember = "full_name";
            cmbClient.ValueMember = "id";
            cmbClient.DataSource = Db.GetTable("SELECT id, full_name FROM clients ORDER BY full_name");

            cmbProperty.DisplayMember = "title";
            cmbProperty.ValueMember = "id";
            cmbProperty.DataSource = Db.GetTable(
                "SELECT id, CONCAT(title, ' (', district, ')') AS title, price FROM properties ORDER BY title");
        }

        private void LoadDeals()
        {
            string sql = "SELECT d.id, d.client_id, d.property_id, c.full_name, p.title, " +
                         "d.created_date, d.price, d.status " +
                         "FROM deals d " +
                         "JOIN clients c ON c.id = d.client_id " +
                         "JOIN properties p ON p.id = d.property_id " +
                         "ORDER BY d.created_date DESC, d.id DESC";
            dgvDeals.DataSource = Db.GetTable(sql);

            UiHelper.HideColumn(dgvDeals, "client_id");
            UiHelper.HideColumn(dgvDeals, "property_id");
            UiHelper.SetColumn(dgvDeals, "id", "ID", null, 35);
            UiHelper.SetColumn(dgvDeals, "full_name", "Клієнт", null, 140);
            UiHelper.SetColumn(dgvDeals, "title", "Об'єкт", null, 160);
            UiHelper.SetColumn(dgvDeals, "created_date", "Дата", "dd.MM.yyyy", 70);
            UiHelper.SetColumn(dgvDeals, "price", "Ціна, $", "N0", 70);
            UiHelper.SetColumn(dgvDeals, "status", "Статус", null, 70);
            dgvDeals.ClearSelection();
        }

        // При виборі об'єкта автоматично підставляємо його ціну
        private void cmbProperty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView item = cmbProperty.SelectedItem as DataRowView;
            if (item != null)
                nudPrice.Value = Db.ToDecimal(item["price"]);
        }

        private void dgvDeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDeals.Rows[e.RowIndex];
            selectedId = Db.ToInt(row.Cells["id"].Value);
            cmbClient.SelectedValue = Db.ToInt(row.Cells["client_id"].Value);
            cmbProperty.SelectedValue = Db.ToInt(row.Cells["property_id"].Value);
            dtpDate.Value = Convert.ToDateTime(row.Cells["created_date"].Value);
            nudPrice.Value = Db.ToDecimal(row.Cells["price"].Value);
            cmbStatus.SelectedItem = Db.ToStr(row.Cells["status"].Value);
            lblSelectedId.Text = "Обрано угоду ID " + selectedId;
        }

        private bool ValidateFields()
        {
            if (cmbClient.SelectedValue == null)
            {
                UiHelper.Warning("Оберіть клієнта.");
                return false;
            }
            if (cmbProperty.SelectedValue == null)
            {
                UiHelper.Warning("Оберіть об'єкт нерухомості.");
                return false;
            }
            if (nudPrice.Value <= 0)
            {
                UiHelper.Warning("Вкажіть ціну угоди.");
                return false;
            }
            return true;
        }

        private List<MySqlParameter> GetParameters()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(Db.P("@client", cmbClient.SelectedValue));
            parameters.Add(Db.P("@property", cmbProperty.SelectedValue));
            parameters.Add(Db.P("@date", dtpDate.Value.Date));
            parameters.Add(Db.P("@price", nudPrice.Value));
            parameters.Add(Db.P("@status", cmbStatus.Text));
            return parameters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string sql = "INSERT INTO deals (client_id, property_id, created_date, price, status) " +
                         "VALUES (@client, @property, @date, @price, @status)";
            if (Db.Execute(sql, GetParameters().ToArray()) > 0)
            {
                UiHelper.Info("Угоду створено.");
                ClearFields();
                LoadDeals();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть угоду в таблиці.");
                return;
            }
            if (!ValidateFields()) return;

            string sql = "UPDATE deals SET client_id = @client, property_id = @property, created_date = @date, " +
                         "price = @price, status = @status WHERE id = @id";
            List<MySqlParameter> parameters = GetParameters();
            parameters.Add(Db.P("@id", selectedId));

            if (Db.Execute(sql, parameters.ToArray()) > 0)
            {
                UiHelper.Info("Угоду оновлено. Поточний етап: " + cmbStatus.Text);
                ClearFields();
                LoadDeals();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                UiHelper.Warning("Спочатку оберіть угоду в таблиці.");
                return;
            }
            if (!UiHelper.Confirm("Видалити обрану угоду?")) return;

            if (Db.Execute("DELETE FROM deals WHERE id = @id", Db.P("@id", selectedId)) > 0)
            {
                ClearFields();
                LoadDeals();
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
            cmbProperty.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
            nudPrice.Value = 0;
            cmbStatus.SelectedIndex = 0;
            lblSelectedId.Text = "Новий запис";
            dgvDeals.ClearSelection();
        }
    }
}
