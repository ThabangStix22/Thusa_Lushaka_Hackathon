using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private ClientData clientRepo = new ClientData();

        [HttpPost("CreateClient")]
        public int CreateClient(Client client)
        {
            return clientRepo.CreateClient(client);
        }

        [HttpGet("GetClient")]
        public Client GetClient(int IdNumber)
        {
            return clientRepo.GetClient(IdNumber);
        }
    }
}
