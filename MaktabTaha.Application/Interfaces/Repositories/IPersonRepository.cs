using MaktabTaha.Application.DTO_s.person.List;
using MaktabTaha.Application.DTO_s.person.Search;
using MaktabTaha.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Interfaces.Repositories
{
    public interface IPersonRepository : IGenericRepository<int, Person>
    {
        Task<List<PersonListDTO>> SearchPerson(SearchPersonListDTO filters);
        Task<List<SearchCasePersonListDTO>> SearchCasePerson(SearchCasePersonListDTO filters);
    }
}
