using System.Data.SqlClient;

namespace WebAPI.Data
{
    public class Connection
    {
        private static readonly string _configuration = "Data Source=DESKTOP-7SJDS25\\THABANGMSSQLSERV;Initial Catalog=Thusa_Lushaka_DB;Integrated Security=True;TrustServerCertificate=True";
        private readonly SqlConnection conn = new SqlConnection(_configuration);

      

        //Opens Connection
        public SqlConnection OpenConnection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

            return conn;
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
        }
    }
}
