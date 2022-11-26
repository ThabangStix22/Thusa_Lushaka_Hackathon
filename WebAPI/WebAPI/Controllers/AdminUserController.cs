using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        private AdminUserData admin = new AdminUserData();
        public int CreateAdminUser(AdminUser adminUser)
        {
            return admin.CreateAdminUser(adminUser);
        }

        public int DeleteAdminUser(int id)
        {
            return admin.DeleteAdminUser(id);
        }
    }
}
