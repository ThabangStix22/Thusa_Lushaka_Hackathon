using WebAPI.Models;

namespace WebAPI.Interface
{
    public interface IHouseHold
    {
        public int CreateHouseHold(Household household);

        public Household GetHousehold(int id);
        public IEnumerable<Household> GetHouseholds();

        public int UpdateHouseHold(Household household);
    }
}
