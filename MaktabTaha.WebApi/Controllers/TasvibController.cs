using MaktabTaha.Application.DTO_s.tasvib.Search;
using MaktabTaha.Application.Features.tasvib.Command.Create;
using MaktabTaha.Application.Features.tasvib.Command.Delete;
using MaktabTaha.Application.Features.tasvib.Command.Update;
using MaktabTaha.Application.Features.tasvib.Query.CaseHeaderWithTasvibs;
using MaktabTaha.Application.Features.tasvib.Query.ListCaseOfTasvib;
using MaktabTaha.Application.Features.tasvib.Query.TasvibDetails;
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


        // لیست پرونده های تصویب
        [HttpGet("/Case-Of-Tasvib")]
        public async Task<IActionResult> GetCaseOfTasvibs([FromQuery] SearchCaseOfTasvibDTO filters)
        {
            return Ok(await Mediator.Send(new GetListCaseOfTasvibCommand { Filters = filters }));
        }


        // فرم نمایش تصویب : اطلاعات هدر فرم و اطلاعات تصویب های انجام شده
        [HttpGet("Case-Header-With-Tasvibs/{caseNumber}")]
        public async Task<IActionResult> GetCaseHeaderWithTasvibs(string caseNumber)
        {
            return Ok(await Mediator.Send(new GetCaseHeaderWithTasvibsCommand { CaseNumber = caseNumber }));
        }

        // اطلاعات جزئیات تصویب
        [HttpGet("Tasvib-Details-With-Helps/{id}")]
        public async Task<IActionResult> GetTasvibDetails(int id)
        {
            return Ok(await Mediator.Send(new GetTasvibDetailsCommand { Id = id }));
        }

    }
}
