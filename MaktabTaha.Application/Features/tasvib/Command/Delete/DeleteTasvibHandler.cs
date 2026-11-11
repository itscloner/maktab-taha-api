using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Command.Delete
{
    public class DeleteTasvibHandler : IRequestHandler<DeleteTasvibCommand, OperationResult<bool>>
    {
        private readonly ITasvibRepository _repository;

        public DeleteTasvibHandler(ITasvibRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<bool>> Handle(DeleteTasvibCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var Tasvib = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (Tasvib == null) return operation.Failure("فرم تصویب یافت نشد");

            await _repository.Delete(Tasvib);
            return operation.Succedded(true);
        }
    }
}
