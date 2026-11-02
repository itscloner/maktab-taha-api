using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.caseDonorHelps.Create
{
    public class CreateCaseDonorHelpsDTO
    {
        public int TasvibId { get; set; }

        public string CaseNumber { get; set; }

        public int RequestTypeId { get; set; }
        public RequestType RequestType { get; set; }

        //مبلغ
        public decimal MoneyAmount { get; set; }

        public int DonorId { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
