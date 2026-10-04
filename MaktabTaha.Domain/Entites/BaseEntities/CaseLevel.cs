using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class CaseLevel : BaseEntity<int>
    {
        public string CaseLevelName { get; set; }
    }
}
