using WebAPI.Interface;
using Dapper;

namespace WebAPI.Data
{
    public class ClientData : IClient
    {
        private Connection _con = new Connection();

        public int CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public int DeleteClient(int IdNumber)
        {
            throw new NotImplementedException();
        }

        public int GetClient(int IdNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public int UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
