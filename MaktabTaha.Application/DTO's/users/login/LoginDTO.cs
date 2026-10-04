using MaktabTaha.Application.DTO_s.users.single;

namespace MaktabTaha.Application.DTO_s.users.login
{
    public class LoginDTO : UserSingleDTO
    {
        public string Token { get; set; }
    }
}
