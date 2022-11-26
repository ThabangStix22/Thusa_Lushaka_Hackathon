using WebAPI.Interface;
using WebAPI.Models;
using Dapper;

namespace WebAPI.Data
{
    public class HouseHoldData : IHouseHold
    {
        private Connection _con = new Connection();
        public int CreateHouseHold(Household household)
        {
            int control = -2;

            Household existHousehold = _con.OpenConnection().QueryFirstOrDefault<Household>(
                $"SELECT * " +
                $"FROM dbo.Household " +
                $"WHERE CL_IdNumber_ = {household.CL_Id_Number} ");


            if (existHousehold == null)
            {
                try
                {
                    control = _con.OpenConnection().Execute(
                        $"INSERT INTO dbo.Household VALUES ({household.CL_Id_Number},0)", household);
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    control = -1;
                }
            }
            else if (existHousehold != null)
            {
                control = 0;
            }

            _con.CloseConnection();
            return control;
        }

        public Household GetHousehold(int id)
        {
            Household household = _con.OpenConnection().QueryFirstOrDefault<Household>
                 ($"SELECT * " +
                 $"FROM dbo.Household " +
                 $"WHERE H_ID = {id}");
            _con.CloseConnection();
            return household;
        }

        public IEnumerable<Household> GetAllHouseholds()
        {
            IEnumerable<Household> existHouse = _con.OpenConnection().Query<Household>
                  ($"SELECT * " +
                  $"FROM dbo.Household ");
            _con.CloseConnection();
            return existHouse;
        }

        public int UpdateHouseHold(Household household)
        {
            throw new NotImplementedException();
        }
    }
}
