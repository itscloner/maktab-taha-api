using MaktabTaha.Application.Features.tasvib.Command.Create;
using MaktabTaha.Application.Features.tasvib.Command.Delete;
using MaktabTaha.Application.Features.tasvib.Command.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasvibController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateTasvib(CreateTasvibCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTasvib(int id)
        {
            return Ok(await Mediator.Send(new DeleteTasvibCommand { Id = id }));
        }

        [HttpPut("{CaseNumber}")]
        public async Task<IActionResult> UpdateTasvib(string CaseNumber, UpdateTasvibCommand command)
        {
            if (CaseNumber != command.CaseNumber)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        
    }
}
