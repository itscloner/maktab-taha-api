using MaktabTaha.Application.Features.casePerson.Command.Create;
using MaktabTaha.Application.Features.casePerson.Command.Delete;
using MaktabTaha.Application.Features.casePerson.Command.Update;
using MaktabTaha.Application.Features.casePerson.Query.List;
using MaktabTaha.Application.Features.casePerson.Query.Single;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasePersonController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateCasePerson(CreateCasePersonCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCasePerosn(int id)
        {
            return Ok(await Mediator.Send(new DeleteCasePersonCommand { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCasePerson(int id, UpdateCasePersonCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetCasePersonList()
        {
            return Ok(await Mediator.Send(new GetCasePersonListCommand()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCasePersonSingle(int id)
        {
            return Ok(await Mediator.Send(new GetSingleCasePersonCommand { Id = id }));
        }
    }
}
