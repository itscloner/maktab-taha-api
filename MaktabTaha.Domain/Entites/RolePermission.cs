using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites
{
    public class RolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public Role Role { get; set; }
        public Permission Permission { get; set; }

    }
}
