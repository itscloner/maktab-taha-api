using MaktabTaha.Application.DTO_s.caseDesc.Search;
using MaktabTaha.Application.Features.caseDesc.Command.Create;
using MaktabTaha.Application.Features.caseDesc.Command.Delete;
using MaktabTaha.Application.Features.caseDesc.Command.Update;
using MaktabTaha.Application.Features.caseDesc.Query.List;
using MaktabTaha.Application.Features.caseDesc.Query.Single;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateCase(CreateCaseCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{CaseNumber}")]
        public async Task<IActionResult> DeleteCase(string caseNumber)
        {
            return Ok(await Mediator.Send(new DeleteCaseCommand { CaseNumber = caseNumber }));
        }

        [HttpPut("{CaseNumber}")]
        public async Task<IActionResult> UpdateCase(string caseNumber, UpdateCaseCommand command)
        {
            if (caseNumber != command.CaseNumber)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetCaseList(SearchCaseDTO filters)
        {
            return Ok(await Mediator.Send(new GetCaseListCommand { Filters = filters }));
        }

        [HttpGet("{CaseNumber}")]
        public async Task<IActionResult> GetCaseSingle(string caseNumber)
        {
            return Ok(await Mediator.Send(new GetSingleCaseCommand { CaseNumber = caseNumber }));
        }
    }
}
