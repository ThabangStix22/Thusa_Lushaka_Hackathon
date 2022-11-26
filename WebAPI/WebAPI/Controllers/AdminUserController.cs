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

        [HttpPost("CreateAdminUser")]
        public int CreateAdminUser(AdminUser adminUser)
        {
            return admin.CreateAdminUser(adminUser);
        }

       

        [HttpGet("GetAdminUsers")]
        public IEnumerable<AdminUser> GetAdminUsers()
        {
            return admin.GetAdminUsers();
        }

        [HttpGet("GetAdminUser/{id}")]
        public AdminUser GetAdminUser(int id)
        {
            return admin.GetAdminUser(id);
        }

        [HttpDelete("DeleteAdminUser")]
        public int DeleteAdminUser(int id)
        {
            return admin.DeleteAdminUser(id);
        }
    }
}
