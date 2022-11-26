using WebAPI.Models;

namespace WebAPI.Interface
{
    public interface IAdminUser
    {
        public int CreateAdminUser(AdminUser adminUser);

        public AdminUser GetAdminUser(int id);
        public IEnumerable<AdminUser> GetAdminUsers();

        public int DeleteAdminUser(int id);
    }
}
