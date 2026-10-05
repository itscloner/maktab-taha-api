using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.person.Search
{
    public class SearchPersonListDTO
    {
        public string? NationalCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
