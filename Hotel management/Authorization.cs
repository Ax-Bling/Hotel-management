using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Hotel_management
{
    class Authorization
    {
        /*private
          string Password, Accesslvl;
        private static string Login;

        public string Autorithation(string Login, string Password)
        {
            string cmdLine = "SELECT *FROM UsersDat WHERE Login = '" + Login + "' AND Password = '" + Password + "'";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelManagmentDB_Connection"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdLine, DB.GetSqlConn());
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Accesslvl = reader.GetValue(3).ToString();
                            MessageBox.Show(Accesslvl,
                            "Помилка", MessageBoxButtons.OK);
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return Accesslvl;
        }*/
    }
}
