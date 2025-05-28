using CovautoAPI.Applicatie.Interfaces;
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Shared.DTOs.Collega;
using CovautoAPI.Shared.DTOs.LeenAuto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovautoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegaController : ControllerBase
    {

        private readonly ICollegaRepository collegaRepository;

        public CollegaController(ICollegaRepository collegaRepository)
        {
            this.collegaRepository = collegaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GeefCollegas()
        {
            return Ok(await collegaRepository.GeefAlleCollegasAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GeefCollegasByID(int id)
        {
            CollegaListItem? retVal = await collegaRepository.GeefCollegaByIDAsync(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

    }
}
