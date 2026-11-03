using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.tasvib.TasvibDetails
{
    public class TasvibDetailsDTO
    {
        public int Id { get; set; }
        public DateTime TasvibDate { get; set; }
        public string CaseNumber { get; set; }
        public string ClientRequestDescription { get; set; }
        public int TasvibStatusId { get; set; }
        public string TasvibStatusName { get; set; }
        public string TasvibReason { get; set; }
        public string Description { get; set; }
        public int ManagerTasvibStatusId { get; set; }
        public string ManagerTasvibStatusName { get; set; }

        public List<CaseDonorHelpDetailsDTO> CaseDonorHelpDetails { get; set; } = new List<CaseDonorHelpDetailsDTO>();
        public List<CaseDonorHelpSummaryDTO> CaseDonorHelpSummary { get; set; } = new List<CaseDonorHelpSummaryDTO>();
    }

    public class CaseDonorHelpDetailsDTO
    {
        public int RequestTypeId { get; set; }
        public string RequestTypeName { get; set; }
        public decimal MoneyAmount { get; set; }
        public int DonorId { get; set; }
        public string DonorFullName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }

    public class CaseDonorHelpSummaryDTO
    {
        public int RequestTypeId { get; set; }
        public string RequestTypeName { get; set; }
        public decimal TotalMoneyAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
