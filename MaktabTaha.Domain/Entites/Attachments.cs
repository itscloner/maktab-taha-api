using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites
{
    public class Attachments : BaseEntity<int>
    {
        public string AttachmentName { get; set; }
        public byte[] Attach  { get; set; }
        public int? PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
