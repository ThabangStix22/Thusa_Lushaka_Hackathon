using WebAPI.Data;

namespace WebAPI.Interface
{
    public interface IClient
    {
        //CRUD
        public int CreateClient(Client client);

        public Client GetClient(int IdNumber);
        public IEnumerable<Client> GetClients();

        public int UpdateClient(Client client);

        public int DeleteClient(int IdNumber);
    }
}
