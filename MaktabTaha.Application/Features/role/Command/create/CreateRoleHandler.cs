using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.create
{
    public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, OperationResult<int>>
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public CreateRoleHandler(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<int>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<int>();
            var exists = await _repository.Exists(x => x.Title == request.Title);
            if (exists) return operation.Failure("این نقش قبلا ثبت شده است");

            var mapped = _mapper.Map<Role>(request);
            var result = _repository.Create(mapped);

            return operation.Succedded(result.Id);

        }

    }
}
