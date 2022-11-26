using Dapper;
using WebAPI.Interface;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AdminUserData : IAdminUser
    {
        private Connection _con = new Connection();

        public int CreateAdminUser(AdminUser adminUser)
        {
            int control = -2;

            AdminUser existAdmin = _con.OpenConnection().QueryFirstOrDefault<AdminUser>(
                $"SELECT * " +
                $"FROM dbo.AdminUser " +
                $"WHERE Ad_ID = {adminUser.Ad_ID} ");


            if (existAdmin == null)
            {
                try
                {
                    control = _con.OpenConnection().Execute(
                        $"INSERT INTO dbo.AdminUser VALUES ('{adminUser.Ad_Name}','{adminUser.Ad_Surname}'" +
                        $",'{adminUser.Ad_EmailAddress}',{adminUser.Ad_CellNumber}, " +
                        $",'{Encrypt.HashString(adminUser.Ad_Password)}','Administrator')", adminUser);
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    control = -1;
                }
            }
            else if (existAdmin != null)
            {
                control = 0;
            }

            _con.CloseConnection();
            return control;
        }

        public int DeleteAdminUser(int id)
        {
            int control = -2;
            try
            {
                control = _con.OpenConnection().Execute
                ($"DELETE FROM dbo.AdminUser " +
                $"WHERE Ad_ID = {id}");

            }
            catch (Exception e)
            {

                e.GetBaseException();
                control = -1;
            }


            _con.CloseConnection();
            return control;
        }

        

        public AdminUser GetAdminUser(int id)
        {
            AdminUser adminUser = _con.OpenConnection().QueryFirstOrDefault<AdminUser>
                 ($"SELECT * " +
                 $"FROM dbo.AdminUser " +
                 $"WHERE Ad_ID = {id}");
            _con.CloseConnection();
            return adminUser;
        }

        public IEnumerable<AdminUser> GetAdminUsers()
        {
            IEnumerable<AdminUser> adminUsers = _con.OpenConnection().Query<AdminUser>
                  ($"SELECT * " +
                  $"FROM dbo.AdminUser ");
            _con.CloseConnection();
            return adminUsers;
        }
    }
}
