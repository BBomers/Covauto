using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CovautoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserveringDataController : ControllerBase
    {
        private readonly IReserveringDataRepository reserveringDataRepository;

        public ReserveringDataController(IReserveringDataRepository reserveringDataRepository)
        {
            this.reserveringDataRepository = reserveringDataRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GeefReservatieData()
        {
            return Ok(await reserveringDataRepository.GeefAlleReservatieDataAsync());
        }

        [HttpGet("search/{titel}")]
        public async Task<IActionResult> ZoekReservatieData(string kenteken)
        {
            return Ok(await reserveringDataRepository.ZoekReservatieDataAsync(kenteken));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GeefReservatie(int id)
        {
            FullReservatie? retVal = await reserveringDataRepository.GeefBoekAsync(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> MaakBoek(MaakReservatieData reservatieData)
        {
            try
            {
                var id = await reserveringDataRepository.CreateReservatieAsync(reservatieData);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservatieData(int id, UpdateReservatieData reservatieData)
        {
            try
            {
                await reserveringDataRepository.UpdateBoekAsync(id, reservatie);
                return Ok();
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteReservatieData(int id)
        {
            try
            {
                await reserveringDataRepository.DeleteReservatieAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
