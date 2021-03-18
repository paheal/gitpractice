using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RosterServiceWebApi.Roster
{
    [ApiController]
    [Route("players")]
    public class PlayerController : Controller
    {
        [HttpGet]
        public IEnumerable<PlayerApiModel> GetPlayers()
        {
            return new List<PlayerApiModel>() {
                  new PlayerApiModel()
                  {
                      LastName = "White",
                      FirstName = "Devon"
                  },
                  new PlayerApiModel()
                  {
                      LastName = "Godwin",
                      FirstName = "Chris"
                  },
                  new PlayerApiModel()
                  {
                      LastName = "Evans",
                      FirstName = "Mike"
                  },
                  new PlayerApiModel()
                  {
                      LastName = "Jason",
                      FirstName = "Pierre-Paul"
                  }
            };

        }
    }
}
