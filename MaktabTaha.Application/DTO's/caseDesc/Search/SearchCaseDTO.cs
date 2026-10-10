using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.caseDesc.Search
{
    public class SearchCaseDTO
    {
        public string? CaseNumber { get; set; }
        public int? RequestId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? NationalCode { get; set; }
        public string? SupervisorFirstName { get; set; }
        public string? SupervisorLastName { get; set; }
        public int? CaseTypeId { get; set; }
        public int? PrivatenessStatusId { get; set; }

    }
}
