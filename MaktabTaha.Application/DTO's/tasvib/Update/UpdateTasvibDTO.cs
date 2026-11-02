using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.tasvib.Update
{
    public class UpdateTasvibDTO
    {
        public int Id { get; set; }
        public DateTime TasvibDate { get; set; }
        
        public string CaseNumber { get; set; }
        public string ClientRequestDescription { get; set; }
        

        //وضعیت تصویب
        public int TasvibStatusId { get; set; }
        public string TasvibReason { get; set; }
        public string Description { get; set; }


    }
}
