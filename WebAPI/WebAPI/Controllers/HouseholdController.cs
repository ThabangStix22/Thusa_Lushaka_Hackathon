using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdController : ControllerBase
    {
        HouseHoldData houseHoldRepo = new HouseHoldData();

        [HttpPost("CreateHouseHold")]
        public int CreateHouseHold(Household household)
        {
            return houseHoldRepo.CreateHouseHold(household);
        }

        [HttpGet("GetHouseHold/{id}")]
        public Household GetHousehold(int id)
        {
            return houseHoldRepo.GetHousehold(id);
        }

        [HttpGet("GetAllHouseHolds")]
        public IEnumerable<Household> GetAllHouseholds()
        {
            return houseHoldRepo.GetAllHouseholds();
        }
    }
}
