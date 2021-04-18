using MySql.Data.MySqlClient;


namespace Hotel_management
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=hotelmanagment");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        /*private static SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelManagmentDB_Connection"].ConnectionString);


        public bool OpenConnection()
        {
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
                return true;
            }
            return false;
        }

        public bool CloseConnection()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                return true;
            }
            return false;
        }

        public static SqlConnection GetSqlConn()
        {
            return sqlConn;
        }
        public static string GetConnToString()
        {
            return sqlConn.ToString();
        }*/
    }
}
