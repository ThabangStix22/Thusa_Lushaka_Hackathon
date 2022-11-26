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

        public int CreateHouseHold(Household household)
        {
            return houseHoldRepo.CreateHouseHold(household);
        }

    }
}
