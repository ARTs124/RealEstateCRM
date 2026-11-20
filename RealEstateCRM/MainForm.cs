using System;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateCRM
{
    /// <summary>
    /// Головне вікно: бічне меню зліва, заголовок зверху і область для розділів.
    /// Кожен розділ — це окремий UserControl, який показується в pnlContent.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly Color menuColor = Color.FromArgb(24, 39, 75);
        private readonly Color activeMenuColor = Color.FromArgb(44, 70, 130);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowSection(new HomeControl(), btnHome);
        }

        /// <summary>Показує обраний розділ і підсвічує відповідну кнопку меню.</summary>
        private void ShowSection(UserControl section, Button menuButton)
        {
            // Видаляємо попередній розділ
            while (pnlContent.Controls.Count > 0)
                pnlContent.Controls[0].Dispose();

            section.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(section);
            lblSectionTitle.Text = menuButton.Text;

            // Підсвічування активної кнопки меню
            foreach (Control control in pnlSidebar.Controls)
            {
                if (control is Button)
                    control.BackColor = menuColor;
            }
            menuButton.BackColor = activeMenuColor;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowSection(new HomeControl(), btnHome);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ShowSection(new ClientsControl(), btnClients);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ShowSection(new PropertiesControl(), btnProperties);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            ShowSection(new RequestsControl(), btnRequests);
        }

        private void btnMatching_Click(object sender, EventArgs e)
        {
            ShowSection(new MatchingControl(), btnMatching);
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            ShowSection(new DealsControl(), btnDeals);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ShowSection(new StatisticsControl(), btnStatistics);
        }
    }
}
