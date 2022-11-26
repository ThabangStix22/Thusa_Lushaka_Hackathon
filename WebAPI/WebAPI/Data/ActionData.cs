using Dapper;
using WebAPI.Interface;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class ActionData : IAction
    {
        private Connection _con = new Connection();
        public int Login(string strEmail, string strPassword)
        {
            Client client = _con.OpenConnection().QueryFirstOrDefault<Client>
                ($"SELECT * " +
                $"FROM dbo.Client " +
                $"WHERE CL_EmailAddress='{strEmail}' AND CL_Password='{Encrypt.HashString(strPassword)}' ");

            AdminUser adminUser = _con.OpenConnection().QueryFirstOrDefault<AdminUser>
                ($"SELECT * " +
                $"FROM dbo.AdminUser " +
                $"WHERE CL_EmailAddress='{strEmail}' AND CL_Password='{Encrypt.HashString(strPassword)}' ");

            int control = -2;
            if (client == null || adminUser == null)
            {
                control = 0;
            }
            else if (client != null || adminUser != null)
            {
                control = 1;
            }
            else if ((client == null || adminUser != null) || (client != null || adminUser == null))
            {
                control = -1;
            }

            _con.CloseConnection();

            return control;
             
        }
    }
}
