using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.tasvib.ListCaseOfTasvib
{
    public class ListCaseOfTasvibDTO
    {
        public int Id { get; set; }
        public DateTime TasvibDate { get; set; }
        public string CaseNumber { get; set; }

        public string SupervisorFirstName { get; set; }
        public string SupervisorLastName { get; set; }

        //وضعیت تصویب
        public int TasvibStatusId { get; set; }
        public string TasvibStatusName { get; set; }

        //وضعیت تایید مدیر
        public int ManagerTasvibStatusId { get; set; }
        public string ManagerTasvibStatusName { get; set; }
    }
}
