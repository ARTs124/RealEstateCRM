using System;
using System.Windows.Forms;

namespace RealEstateCRM
{
    internal static class Program
    {
        /// <summary>
        /// Точка входу в програму.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Спочатку перевіряємо, чи доступний сервер MySQL (XAMPP)
            if (!Db.TestConnection())
                return;

            Application.Run(new MainForm());
        }
    }
}
