using Microsoft.AspNetCore.Mvc;

namespace CovautoAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeenAutoController : Controller
    {
        public readonly LeenAutoRepository leenAutoRepository;

        public LeenAutoController(LeenAutoRepository leenAutoRepository)
        {
            this.leenAutoRepository = leenAutoRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FullLeenAutoListItem>> GetAllLeenAutos() 
        {
            var leenAutos = leenAutoRepository.getAllLeenAutos();
            return Ok(leenAutos);
        }

        [HttpGet("search/{kenteken}")]
        public ActionResult<IEnumerable<FullLeenAutoListItem>> ZoekLeenAutos([FromQuery] string )
    }
}
