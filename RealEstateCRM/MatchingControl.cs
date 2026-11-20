using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateCRM
{
    /// <summary>Розділ «Підбір об'єктів»: порівнює заявку з усіма об'єктами за допомогою Matcher.</summary>
    public partial class MatchingControl : UserControl
    {
        public MatchingControl()
        {
            InitializeComponent();
        }

        private void MatchingControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvResults);

            // У списку показуємо тільки активні заявки
            string sql = "SELECT r.id, CONCAT('№', r.id, ' — ', c.full_name, ' (', r.property_type, ')') AS title " +
                         "FROM requests r JOIN clients c ON c.id = r.client_id " +
                         "WHERE r.status = 'Активна' ORDER BY r.id DESC";
            cmbRequest.DisplayMember = "title";
            cmbRequest.ValueMember = "id";
            cmbRequest.DataSource = Db.GetTable(sql);
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (cmbRequest.SelectedValue == null)
            {
                UiHelper.Warning("Немає активних заявок. Додайте заявку в розділі «Заявки».");
                return;
            }

            // 1. Читаємо вимоги клієнта із заявки
            DataTable requestTable = Db.GetTable("SELECT * FROM requests WHERE id = @id",
                Db.P("@id", cmbRequest.SelectedValue));
            if (requestTable.Rows.Count == 0) return;

            DataRow r = requestTable.Rows[0];
            ClientRequest request = new ClientRequest();
            request.PropertyType = Db.ToStr(r["property_type"]);
            request.MinArea = Db.ToDecimal(r["min_area"]);
            request.MaxArea = Db.ToDecimal(r["max_area"]);
            request.MinBudget = Db.ToDecimal(r["min_budget"]);
            request.MaxBudget = Db.ToDecimal(r["max_budget"]);
            request.District = Db.ToStr(r["district"]);
            request.Rooms = Db.ToInt(r["rooms"]);
            ShowRequestInfo(request);

            // 2. Завантажуємо об'єкти, які ще не продані
            DataTable properties = Db.GetTable(
                "SELECT id, title, property_type, price, area, district, rooms FROM properties " +
                "WHERE id NOT IN (SELECT property_id FROM deals WHERE status = 'Продано')");

            // 3. Таблиця для результатів
            DataTable results = new DataTable();
            results.Columns.Add("title", typeof(string));
            results.Columns.Add("type", typeof(string));
            results.Columns.Add("price", typeof(decimal));
            results.Columns.Add("area", typeof(decimal));
            results.Columns.Add("district", typeof(string));
            results.Columns.Add("rooms", typeof(int));
            results.Columns.Add("percent", typeof(int));

            // 4. Рахуємо відсоток збігу для кожного об'єкта
            foreach (DataRow row in properties.Rows)
            {
                PropertyItem property = new PropertyItem();
                property.Id = Db.ToInt(row["id"]);
                property.Title = Db.ToStr(row["title"]);
                property.Type = Db.ToStr(row["property_type"]);
                property.Price = Db.ToDecimal(row["price"]);
                property.Area = Db.ToDecimal(row["area"]);
                property.District = Db.ToStr(row["district"]);
                property.Rooms = Db.ToInt(row["rooms"]);

                int percent = Matcher.CalculateMatch(request, property);
                if (percent > 0)
                {
                    results.Rows.Add(property.Title, property.Type, property.Price, property.Area,
                                     property.District, property.Rooms, percent);
                }
            }

            // 5. Сортуємо: спочатку найбільш підходящі, при однаковому відсотку — дешевші
            results.DefaultView.Sort = "percent DESC, price ASC";
            dgvResults.DataSource = results.DefaultView;

            UiHelper.SetColumn(dgvResults, "title", "Назва об'єкта", null, 180);
            UiHelper.SetColumn(dgvResults, "type", "Тип нерухомості", null, 110);
            UiHelper.SetColumn(dgvResults, "price", "Ціна, $", "N0", 80);
            UiHelper.SetColumn(dgvResults, "area", "Площа, м²", "N1", 70);
            UiHelper.SetColumn(dgvResults, "district", "Район", null, 90);
            UiHelper.SetColumn(dgvResults, "rooms", "Кімнат", null, 60);
            UiHelper.SetColumn(dgvResults, "percent", "Збіг, %", null, 70);

            lblResults.Text = "Результати підбору — знайдено об'єктів: " + results.Rows.Count;
            if (results.Rows.Count == 0)
                UiHelper.Info("Підходящих об'єктів не знайдено. Спробуйте змінити вимоги в заявці.");
        }

        /// <summary>Показує вимоги заявки одним рядком над результатами.</summary>
        private void ShowRequestInfo(ClientRequest request)
        {
            string budget = (request.MinBudget > 0 || request.MaxBudget > 0)
                ? request.MinBudget.ToString("N0") + " – " + (request.MaxBudget > 0 ? request.MaxBudget.ToString("N0") : "…") + " $"
                : "не важливо";
            string area = (request.MinArea > 0 || request.MaxArea > 0)
                ? request.MinArea.ToString("N0") + " – " + (request.MaxArea > 0 ? request.MaxArea.ToString("N0") : "…") + " м²"
                : "не важливо";
            string district = request.District != "" ? request.District : "не важливо";
            string rooms = request.Rooms > 0 ? request.Rooms.ToString() : "не важливо";

            lblRequestInfo.Text = "Тип: " + request.PropertyType + "   |   Бюджет: " + budget +
                                  "   |   Площа: " + area + "   |   Район: " + district + "   |   Кімнат: " + rooms;
        }

        // Підсвічуємо рядки кольором залежно від відсотка збігу
        private void dgvResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                int percent = Db.ToInt(row.Cells["percent"].Value);
                if (percent >= 80)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 252, 231);   // зелений
                else if (percent >= 50)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 195);   // жовтий
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);   // червоний
            }
        }
    }
}
