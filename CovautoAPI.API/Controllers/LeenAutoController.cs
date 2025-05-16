using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Shared.DTOs.LeenAuto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CovautoAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeenAutoController : ControllerBase
    {

        private readonly ILeenAutoRepository leenAutoRepository;

        public LeenAutoController(ILeenAutoRepository leenAutoRepository)
        {
            this.leenAutoRepository = leenAutoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GeefLeenAutoen()
        {
            return Ok(await leenAutoRepository.GeefAlleLeenAutoenAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GeefLeenAuto(int id)
        {
            LeenAutoListItem? retVal = await leenAutoRepository.GeefLeenAuto(id);
            return retVal != null ? Ok(retVal) : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeenAuto(int id, LeenAutoListItem LeenAuto)
        {
            try
            {
                await leenAutoRepository.UpdateLeenAutoAsync(id, LeenAuto);
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

    }
}
