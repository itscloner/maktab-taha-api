using MaktabTaha.Application.Features.attachment.Command.Create;
using MaktabTaha.Application.Features.attachment.Command.Delete;
using MaktabTaha.Application.Features.attachment.Command.Update;
using MaktabTaha.Application.Features.attachment.Query.List;
using MaktabTaha.Application.Features.attachment.Query.Single;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateAttachment([FromForm] CreateAttachmentCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> AttachmentList()
        {
            var result = await Mediator.Send(new GetAttachmentListCommand());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttachmentById(int id)
        {
            var result = await Mediator.Send(new GetSingleAttachmentCommand() { Id = id });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAttachment(int id, [FromForm] UpdateAttachmentCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator
                .Send(new DeleteAttachmentCommand { Id = id }));
        }
    }
}
