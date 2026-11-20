using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateCRM
{
    /// <summary>
    /// Клас для роботи з базою даних MySQL (XAMPP).
    /// Усі запити до бази проходять через методи цього класу.
    /// </summary>
    public static class Db
    {
        // Рядок підключення: сервер XAMPP на цьому комп'ютері, користувач root без пароля
        public static string ConnectionString =
            "server=localhost;port=3306;database=real_estate_crm;user=root;password=;charset=utf8mb4;SslMode=None;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        /// <summary>Перевіряє, чи можна підключитися до MySQL (викликається при запуску програми).</summary>
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не вдалося підключитися до бази даних MySQL.\n\n" +
                    "Перевірте, що:\n" +
                    "1) у XAMPP Control Panel запущено MySQL;\n" +
                    "2) базу real_estate_crm імпортовано з файлу database.sql.\n\n" +
                    "Текст помилки: " + ex.Message,
                    "Помилка підключення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Виконує SELECT і повертає результат у вигляді таблиці (для DataGridView та ComboBox).</summary>
        public static DataTable GetTable(string sql, params MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = GetConnection())
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            return table;
        }

        /// <summary>Виконує INSERT, UPDATE або DELETE. Повертає кількість змінених рядків або -1 при помилці.</summary>
        public static int Execute(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
                return -1;
            }
        }

        /// <summary>Повертає одне значення (наприклад, результат COUNT або SUM).</summary>
        public static object GetValue(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
                return null;
            }
        }

        // ---------- Допоміжні методи ----------

        /// <summary>Створює параметр SQL-запиту. null перетворюється на NULL у базі.</summary>
        public static MySqlParameter P(string name, object value)
        {
            return new MySqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>0 означає «не вказано», тому в базу записуємо NULL.</summary>
        public static object NullIfZero(decimal value)
        {
            if (value == 0) return DBNull.Value;
            return value;
        }

        public static decimal ToDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            return Convert.ToDecimal(value);
        }

        public static int ToInt(object value)
        {
            if (value == null || value == DBNull.Value) return 0;
            return Convert.ToInt32(value);
        }

        public static string ToStr(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            return value.ToString();
        }

        private static void ShowError(Exception ex)
        {
            string message = "Помилка бази даних: " + ex.Message;

            MySqlException mySqlError = ex as MySqlException;
            if (mySqlError != null)
            {
                // 1451 — запис використовується в іншій таблиці (зовнішній ключ)
                if (mySqlError.Number == 1451)
                    message = "Цей запис неможливо видалити, тому що він використовується в угодах.\n" +
                              "Спочатку видаліть пов'язані угоди.";
                // 1042 — сервер MySQL недоступний
                else if (mySqlError.Number == 1042)
                    message = "Немає з'єднання з MySQL. Перевірте, що в XAMPP запущено MySQL.";
            }

            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
