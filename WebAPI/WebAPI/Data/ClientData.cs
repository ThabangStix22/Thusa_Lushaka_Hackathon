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
                $"FROM dbo.Client " +
                $"WHERE CL_IdNumber = {client.CL_IdNumber} ");


            if(existClient==null)
            {
                try
                {
                    control = _con.OpenConnection().Execute(
                        $"INSERT INTO dbo.Client VALUES ({client.CL_IdNumber},'{client.CL_Name}','{client.CL_Surname}'" +
                        $",'{client.CL_Address}','{client.CL_EmailAddress}',{client.CL_CellNumber},{client.CL_Gender}" +
                        $",'{client.CL_Affidavit}','{Encrypt.HashString(client.CL_Password)}','{client.CL_Role}')");
                }catch(Exception e)
                {
                    e.GetBaseException();
                    control = -1;
                }
            }
            else if(existClient != null)
            {
                control = 0;
            }

            _con.CloseConnection();
            return control;

        }

        public int DeleteClient(int IdNumber)
        {
            int control = -2;
            try
            {
                control = _con.OpenConnection().Execute
                ($"DELETE FROM dbo.Client " +
                $"WHERE CL_IdNumber = {IdNumber}");

            }catch(Exception e)
            {

                e.GetBaseException();
                control = -1;
            }


            _con.CloseConnection();
            return control;
        }

        public Client GetClient(int IdNumber)
        {
            Client client = _con.OpenConnection().QueryFirstOrDefault<Client>
                 ($"SELECT * " +
                 $"FROM dbo.Client " +
                 $"WHERE CL_IdNumber = {IdNumber}");
            _con.CloseConnection();
            return client;
        }

        public IEnumerable<Client> GetClients()
        {
           IEnumerable<Client> clients = _con.OpenConnection().Query<Client>
                 ($"SELECT * " +
                 $"FROM dbo.Client ");
            _con.CloseConnection();
            return clients;
        }



        public int UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
