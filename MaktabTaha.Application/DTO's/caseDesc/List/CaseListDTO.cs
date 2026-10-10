using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.caseDesc.List
{
    public class CaseListDTO
    {
        public int Id { get; set; }
        public string CaseNumber { get; set; }
        public int RequestId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string NationalCode { get; set; }
        public string SupervisorFirstName { get; set; }
        public string SupervisorLastName { get; set; }
        public int HouseHeadStatusId { get; set; }
        public int CaseTypeId { get; set; }
        public int PrivatenessStatusId { get; set; }
        
    }
}
