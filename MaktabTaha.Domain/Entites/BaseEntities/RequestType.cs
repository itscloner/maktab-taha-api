using MaktabTaha.Domain.Common;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class RequestType : BaseEntity<int>
    {
        public string RequestTypeName { get; set; }
        public IsContinuous IsContinuous { get; set; }
    }

    public enum IsContinuous
    {
        NotContinuous = 1,
        Continuous = 2
    }
}
