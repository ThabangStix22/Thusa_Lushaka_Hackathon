using WebAPI.Interface;
using Dapper;

namespace WebAPI.Data
{
    public class ClientData : IClient
    {
        private Connection _con = new Connection();

        public int CreateClient(Client client)
        {
            int control = -2;

            Client existClient = _con.OpenConnection().QueryFirstOrDefault<Client>(
                $"SELECT * " +
                $"FROM dbo.Client" +
                $"WHERE CL_IdNumber = {client.CL_IdNumber} ");

            if(existClient==null)
            {
                try
                {
                    control = _con.OpenConnection().Execute(
                        $"INSERT INTO dbo.Client ({client.CL_IdNumber},'')");
                }catch(Exception e)
                {
                    e.GetBaseException();
                }
            }
            else
            {


            }
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
