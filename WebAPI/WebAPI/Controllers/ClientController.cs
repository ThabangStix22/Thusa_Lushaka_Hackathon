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

        [HttpGet("GetAllClients")]
        public IEnumerable<Client> GetClients()
        {
            return clientRepo.GetClients();
        }

        [HttpPut("UpdateClient")]
        public int UpdateClient(Client client)
        {
            return clientRepo.UpdateClient(client);
        }

        [HttpDelete("DeleteClient")]
        public int DeleteClient(int IdNumber)
        {
            return clientRepo.DeleteClient(IdNumber);
        }
    }
}
