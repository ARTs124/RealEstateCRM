using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace RealEstateCRM
{
    /// <summary>Розділ «Статистика»: показники продажів і експорт в Excel (ClosedXML).</summary>
    public partial class StatisticsControl : UserControl
    {
        // Показники зберігаємо в полях, щоб використати їх і на екрані, і в Excel
        private int totalDeals;
        private int soldCount;
        private decimal soldSum;
        private int activeDeals;

        public StatisticsControl()
        {
            InitializeComponent();
        }

        private void StatisticsControl_Load(object sender, EventArgs e)
        {
            UiHelper.StyleGrid(dgvByStatus);
            LoadStatistics();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            totalDeals = Db.ToInt(Db.GetValue("SELECT COUNT(*) FROM deals"));
            soldCount = Db.ToInt(Db.GetValue("SELECT COUNT(*) FROM deals WHERE status = 'Продано'"));
            soldSum = Db.ToDecimal(Db.GetValue("SELECT IFNULL(SUM(price), 0) FROM deals WHERE status = 'Продано'"));
            activeDeals = totalDeals - soldCount;   // активні — усі, що ще не продані

            lblTotalDealsValue.Text = totalDeals.ToString();
            lblSoldValue.Text = soldCount.ToString();
            lblSumValue.Text = soldSum.ToString("N0");
            lblActiveValue.Text = activeDeals.ToString();

            dgvByStatus.DataSource = GetStatusTable();
            UiHelper.SetColumn(dgvByStatus, "Сума, $", "Сума, $", "N0");
        }

        /// <summary>Кількість і сума угод за кожним етапом.</summary>
        private DataTable GetStatusTable()
        {
            string sql = "SELECT status AS `Етап угоди`, COUNT(*) AS `Кількість угод`, SUM(price) AS `Сума, $` " +
                         "FROM deals GROUP BY status " +
                         "ORDER BY FIELD(status, 'В пошуку', 'Перегляд', 'Завдаток', 'Продано')";
            return Db.GetTable(sql);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "statystyka_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            LoadStatistics();   // беремо найсвіжіші дані

            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    // ----- Аркуш 1: основні показники -----
                    IXLWorksheet sheet = workbook.Worksheets.Add("Статистика");
                    sheet.Cell(1, 1).Value = "Статистика продажів агенції нерухомості";
                    sheet.Cell(1, 1).Style.Font.Bold = true;
                    sheet.Cell(1, 1).Style.Font.FontSize = 14;
                    sheet.Cell(2, 1).Value = "Дата формування: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                    sheet.Cell(4, 1).Value = "Показник";
                    sheet.Cell(4, 2).Value = "Значення";
                    sheet.Range(4, 1, 4, 2).Style.Font.Bold = true;
                    sheet.Range(4, 1, 4, 2).Style.Fill.BackgroundColor = XLColor.LightSteelBlue;

                    sheet.Cell(5, 1).Value = "Загальна кількість угод";
                    sheet.Cell(5, 2).Value = totalDeals;
                    sheet.Cell(6, 1).Value = "Кількість проданих об'єктів";
                    sheet.Cell(6, 2).Value = soldCount;
                    sheet.Cell(7, 1).Value = "Загальна сума завершених продажів, $";
                    sheet.Cell(7, 2).Value = soldSum;
                    sheet.Cell(7, 2).Style.NumberFormat.Format = "#,##0";
                    sheet.Cell(8, 1).Value = "Кількість активних угод";
                    sheet.Cell(8, 2).Value = activeDeals;
                    sheet.Range(4, 1, 8, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    sheet.Range(4, 1, 8, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    sheet.Cell(10, 1).Value = "Угоди за етапами";
                    sheet.Cell(10, 1).Style.Font.Bold = true;
                    sheet.Cell(11, 1).InsertTable(GetStatusTable());
                    sheet.Columns().AdjustToContents();

                    // ----- Аркуш 2: список усіх угод -----
                    IXLWorksheet dealsSheet = workbook.Worksheets.Add("Угоди");
                    DataTable deals = Db.GetTable(
                        "SELECT d.id AS `ID`, c.full_name AS `Клієнт`, p.title AS `Об'єкт`, " +
                        "d.created_date AS `Дата`, d.price AS `Ціна, $`, d.status AS `Статус` " +
                        "FROM deals d JOIN clients c ON c.id = d.client_id " +
                        "JOIN properties p ON p.id = d.property_id ORDER BY d.created_date");
                    dealsSheet.Cell(1, 1).InsertTable(deals);
                    dealsSheet.Column(4).Style.DateFormat.Format = "dd.MM.yyyy";
                    dealsSheet.Column(5).Style.NumberFormat.Format = "#,##0";
                    dealsSheet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);
                }
                UiHelper.Info("Статистику збережено у файл:\n" + saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                // Найчастіша причина — файл з такою назвою вже відкрито в Excel
                UiHelper.Warning("Не вдалося зберегти файл. Можливо, він відкритий в Excel.\n\n" + ex.Message);
            }
        }
    }
}
