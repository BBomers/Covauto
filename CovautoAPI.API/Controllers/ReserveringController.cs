using System.ComponentModel.DataAnnotations;
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Domain.Entities;
using CovautoAPI.Shared.DTOs.Reserveringen;
using Microsoft.AspNetCore.Mvc;

namespace CovautoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserveringController : ControllerBase
    {
        private readonly IReserveringenRepository reserveringRepository;

        public ReserveringController(IReserveringenRepository reserveringRepository)
        {
            this.reserveringRepository = reserveringRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GeefReservaties()
        {
            return Ok(await reserveringRepository.GeefAlleReserveringenAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GeefReservatie(int id)
        {
            ReserveringListItem? retVal = await reserveringRepository.GeefReservering(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> MaakBoek(CreateReservering reservering)
        {
            try
            {
                var id = await reserveringRepository.CreateBoekAsync(reservering);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservatie(int id, ReserveringListItem reservatie)
        {
            try
            {
                await reserveringRepository.UpdateReserveringAsync(id, reservatie);
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
                await reserveringRepository.DeleteReserveringAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
