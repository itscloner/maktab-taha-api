using MaktabTaha.Application.DTO_s.tasvib.Update;
using MaktabTaha.Application.Helpers;
using MediatR;

namespace MaktabTaha.Application.Features.tasvib.Command.Update
{
    public class UpdateTasvibCommand : IRequest<OperationResult<UpdateTasvibDTO>>
    {
        public string CaseNumber { get; set; }
        public string ClientRequestDescription { get; set; }
        public int TasvibStatusId { get; set; }
        public string TasvibReason { get; set; }
        public string Description { get; set; }

    }
}
