using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.tasvib.CaseHeaderWithTasvibs
{
    public class CaseHeaderWithTasvibsDTO
    {
        public string CaseNumber { get; set; }
        public string SupervisorFirstName { get; set; }
        public string SupervisorLastName { get; set; }
        public int PrivatenessStatusId { get; set; }
        public string PrivatenessStatusName { get; set; }
        public int CaseStageId { get; set; }
        public string CaseStageName { get; set; }
        public List<TasvibListDTO> TasvibList { get; set; } = new List<TasvibListDTO>();

    }

    public class TasvibListDTO
    {
        public int Id { get; set; }
        public DateTime TavibDate { get; set; }
        public string CaseNumber { get; set; }
        public string ClientRequestDescription { get; set; }

    }
}
