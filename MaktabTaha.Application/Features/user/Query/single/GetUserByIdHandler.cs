using AutoMapper;
using MaktabTaha.Application.DTO_s.users.single;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user.Query.single
{
    class GetUserByIdHandler : IRequestHandler<GetUserByIdCommand, OperationResult<UserSingleDTO>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<OperationResult<UserSingleDTO>> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<UserSingleDTO>();
            var user = await _repository.GetBy(request.Id);

            if(user == null)
            {
                return operation.Failure("کاربر یافت نشد");
            }

            var result = _mapper.Map<UserSingleDTO>(user);
            return operation.Succedded(result);
        }
    }
}
