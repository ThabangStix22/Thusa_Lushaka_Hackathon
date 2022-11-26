using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private ActionData actionData = new ActionData();

        [HttpGet("Login/{strEmail}/{strPassword}")]
        public int Login(string strEmail, string strPassword)
        {
            return actionData.Login(strEmail, strPassword);
        }
    }
}
