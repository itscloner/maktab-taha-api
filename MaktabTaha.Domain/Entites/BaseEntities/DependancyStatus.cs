using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    // وضعیت تکفل
    public class DependancyStatus : BaseEntity<int>
    {
        public string DependencyStatusName { get; set; }
    }
}
