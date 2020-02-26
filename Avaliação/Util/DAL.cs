using MySql.Data.MySqlClient;
using System.Data;

namespace Avaliação.Util
{

    public class DAL
    {
        private static string server = "172.30.11.5";
        private static string database = "Avaliacao";
        private static string user = "root";
        private static string password = "tkl@2018";
        private string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";

        private MySqlConnection connection;

        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        //Executa SELECTs
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;
        }

        //Executa INSERTs, UPDATEs, DELETEs
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
