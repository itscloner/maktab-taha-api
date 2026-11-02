using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.tasvib.Single
{
    public class SingleTasvibDTO
    {
        public int Id { get; set; }
        public DateTime TasvibDate { get; set; }
        public string CaseNumber { get; set; }
        public string ClientRequestDescription { get; set; }

        //وضعیت تصویب
        public int TasvibStatusId { get; set; }
        public string TasvibReason { get; set; }
        public string Description { get; set; }

        //وضعیت تایید مدیر
        public int ManagerTasvibStatusId { get; set; }
    }
}
