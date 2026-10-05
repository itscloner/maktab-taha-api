using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.attachment.Single
{
    public class AttachmentSingleDTO
    {
        public int Id { get; set; }
        public string AttachmentName { get; set; }
        public byte[] Attach { get; set; }
        public int PersonId { get; set; }
    }
}
