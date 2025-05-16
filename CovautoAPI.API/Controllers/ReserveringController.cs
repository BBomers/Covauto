using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CovautoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserveringController : ControllerBase
    {
        private readonly IReserveringRepository reserveringRepository;

        public ReserveringController(IReserveringRepository reserveringRepository)
        {
            this.reserveringRepository = reserveringRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GeefReservaties()
        {
            return Ok(await reserveringRepository.GeefAlleReservatiesAsync());
        }

        [HttpGet("search/{titel}")]
        public async Task<IActionResult> ZoekReservaties(string kenteken)
        {
            return Ok(await reserveringRepository.ZoekReserveringAsync(kenteken));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GeefReservatie(int id)
        {
            FullReservatieData? retVal = await reserveringRepository.GeefReservatieAsync(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> MaakBoek(MaakReservatie reservatie)
        {
            try
            {
                var id = await reserveringRepository.CreateReservatieAsync(reservatie);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservatie(int id, UpdateReservatie reservatie)
        {
            try
            {
                await reserveringRepository.UpdateBoekAsync(id, reservatie);
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
        public async Task<IActionResult> DeleteReservatie(int id)
        {
            try
            {
                await reserveringRepository.DeleteReservatieAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
