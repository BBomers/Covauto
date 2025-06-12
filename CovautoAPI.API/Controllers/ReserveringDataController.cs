using System.ComponentModel.DataAnnotations;
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Shared.DTOs.ReserveringData;
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
            return Ok(await reserveringDataRepository.GeefAlleReserveringDataenAsync());
        }

        [HttpGet("ByReserveringID/{reservereringsId}")]
        public async Task<IActionResult> GeefReservatieDataByReserveringID(int reservereringsId)
        {
            return Ok(await reserveringDataRepository.GeefAlleReserveringDatabyReserevingIdAsync(reservereringsId));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GeefReservatie(int id)
        {
            ReserveringDataListItem? retVal = await reserveringDataRepository.GeefReserveringData(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> MaakBoek(CreateReserveringData reservatieData)
        {
            try
            {
                var id = await reserveringDataRepository.CreateBoekAsync(reservatieData);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservatieData(int id, ReserveringDataListItem reservatieData)
        {
            try
            {
                await reserveringDataRepository.UpdateReserveringDataAsync(id, reservatieData);
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
                await reserveringDataRepository.DeleteReserveringDataAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
