using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites
{
    public class Tasvib : BaseEntity<int>
    {
        // شماره تصویب همان Id داخل BaseEntity است

        public DateTime TasvibDate { get; set; }
        public int TahghighId { get; set; }
        public Tahghigh Tahghigh { get; set; }
        public string CaseNumber { get; set; }
        public Case Case { get; set; }
        public string ClientRequestDescription { get; set; }
        public int MosavebId { get; set; }
        public Donor Mosaveb { get; set; }
        
        //وضعیت تصویب
        public TasvibStatus TasvibStatus { get; set; }
        public string TasvibReason { get; set; }
        public string Description { get; set; }
        
        //وضعیت تایید مدیر
        public TasvibStatus ManagerTasvibStatus { get; set; }
    }

    public enum TasvibStatus
    {
        // وضعیت تصویب : تصویب و عدم تصویب
        NotApprove = 0,
        Approve
    }
}
