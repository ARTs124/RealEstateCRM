using System;
using System.Windows.Forms;

namespace RealEstateCRM
{
    /// <summary>Головна панель: основні показники та останні угоди.</summary>
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvLastDeals);

            lblClientsValue.Text = Db.ToInt(Db.GetValue("SELECT COUNT(*) FROM clients")).ToString();
            lblPropertiesValue.Text = Db.ToInt(Db.GetValue("SELECT COUNT(*) FROM properties")).ToString();
            lblRequestsValue.Text = Db.ToInt(Db.GetValue("SELECT COUNT(*) FROM requests WHERE status = 'Активна'")).ToString();
            lblSoldValue.Text = Db.ToInt(Db.GetValue(
                "SELECT COUNT(DISTINCT property_id) FROM deals WHERE status = 'Продано'")).ToString();

            // Таблиця тільки для перегляду, тому одразу даємо стовпцям українські назви
            string sql =
                "SELECT c.full_name AS `Клієнт`, p.title AS `Об'єкт`, d.created_date AS `Дата`, " +
                "d.price AS `Ціна, $`, d.status AS `Статус` " +
                "FROM deals d " +
                "JOIN clients c ON c.id = d.client_id " +
                "JOIN properties p ON p.id = d.property_id " +
                "ORDER BY d.created_date DESC, d.id DESC LIMIT 5";
            dgvLastDeals.DataSource = Db.GetTable(sql);
            UiHelper.SetColumn(dgvLastDeals, "Дата", "Дата", "dd.MM.yyyy");
            UiHelper.SetColumn(dgvLastDeals, "Ціна, $", "Ціна, $", "N0");
        }
    }
}
