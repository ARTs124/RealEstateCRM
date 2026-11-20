using System.Drawing;
using System.Windows.Forms;

namespace RealEstateCRM
{
    /// <summary>
    /// Спільні методи для інтерфейсу: оформлення таблиць і повідомлення.
    /// </summary>
    public static class UiHelper
    {
        /// <summary>Однакове оформлення для всіх DataGridView у програмі.</summary>
        public static void StyleGrid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(226, 232, 240);
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 39, 75);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 36;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.RowTemplate.Height = 30;
        }

        /// <summary>Задає заголовок, формат і відносну ширину стовпця.</summary>
        public static void SetColumn(DataGridView grid, string column, string header, string format = null, int width = 100)
        {
            if (!grid.Columns.Contains(column)) return;

            grid.Columns[column].HeaderText = header;
            grid.Columns[column].FillWeight = width;
            if (format != null)
                grid.Columns[column].DefaultCellStyle.Format = format;
        }

        public static void HideColumn(DataGridView grid, string column)
        {
            if (grid.Columns.Contains(column))
                grid.Columns[column].Visible = false;
        }

        public static void Info(string text)
        {
            MessageBox.Show(text, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string text)
        {
            MessageBox.Show(text, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirm(string text)
        {
            return MessageBox.Show(text, "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
