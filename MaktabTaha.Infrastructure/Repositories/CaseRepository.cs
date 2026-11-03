using MaktabTaha.Application.DTO_s.caseDesc.List;
using MaktabTaha.Application.DTO_s.caseDesc.Search;
using MaktabTaha.Application.DTO_s.caseDesc.Single;
using MaktabTaha.Application.DTO_s.tasvib.CaseHeaderWithTasvibs;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure.Repositories
{
    public class CaseRepository : GenericRepository<int, Case>, ICaseRepository
    {
        private readonly ApplicationDbContext _context;
        public CaseRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        // فرم نمایش تصویب : اطلاعات هدر فرم و اطلاعات تصویب های انجام شده
        public async Task<CaseHeaderWithTasvibsDTO> GetCaseHeaderWithTasvibs(string caseNumber)
        {


            //    return await _context.CaseBNF
            //                              .AsNoTracking()
            //                              .Where(x => x.CaseNumber == caseNumber)
            //                              .Select(x => new CaseHeaderWithTasvibsDTO
            //                              {
            //                                  CaseNumber = x.CaseNumber,
            //                                  SupervisorFirstName = x.CasePersons
            //                                                                    .Where(x => x.RelationId == 1)
            //                                                                    .Select(x => x.Person.FirstName)
            //                                                                    .FirstOrDefault(),
            //                                  SupervisorLastName = x.CasePersons
            //                                                                    .Where(x => x.RelationId == 1)
            //                                                                    .Select(x => x.Person.LastName)
            //                                                                    .FirstOrDefault(),
            //                                  PrivatenessStatusId = x.PrivatenessStatusId,
            //                                  PrivatenessStatusName = x.PrivatenessStatus.PrivatenessStatusName,
            //                                  CaseStageId = x.CaseStageId,
            //                                  CaseStageName = x.CaseStage.CaseStageDesc,
            //                                  TasvibList = x.Tasvibs.Select(x => new TasvibListDTO
            //                                  {
            //                                      Id = x.Id,
            //                                      TavibDate = x.TasvibDate,
            //                                      CaseNumber = x.CaseNumber,
            //                                      ClientRequestDescription = x.ClientRequestDescription

            //                                  }).ToList()
            //                              })
            //                              .FirstOrDefaultAsync();
            //


            // برای یکبار تولید subquery برای نام و نام خانوادگی سرپرست
            return await (
               from c in _context.CaseBNF.AsNoTracking()
               where c.CaseNumber == caseNumber

               // let برای تعریف متغیر میانی در Linq Query
               let supervisor = c.CasePersons
                                           .Where(x => x.RelationId == 1)
                                           .Select(x => x.Person)

               select (new CaseHeaderWithTasvibsDTO
               {
                   CaseNumber = c.CaseNumber,

                   SupervisorFirstName = supervisor.Select(x => x.FirstName).FirstOrDefault(),
                   SupervisorLastName = supervisor.Select(x => x.LastName).FirstOrDefault(),

                   PrivatenessStatusId = c.PrivatenessStatusId,
                   PrivatenessStatusName = c.PrivatenessStatus.PrivatenessStatusName,

                   CaseStageId = c.CaseStageId,
                   CaseStageName = c.CaseStage.CaseStageDesc,

                   TasvibList = c.Tasvibs.Select(x => new TasvibListDTO
                   {
                       Id = x.Id,
                       TavibDate = x.TasvibDate,
                       CaseNumber = x.CaseNumber,
                       ClientRequestDescription = x.ClientRequestDescription
                   }).ToList()
               })
               ).FirstOrDefaultAsync();
        }


        public async Task<CaseMoshaverehSingleDTO> GetCaseMoshaverehSingle(string caseNumber)
        {
            return await _context.CaseBNF
                                    .AsNoTracking()
                                    .Where(x => x.CaseNumber == caseNumber)
                                    .Select(x => new CaseMoshaverehSingleDTO
                                    {
                                        Id = x.Id,
                                        SupervisorFirstName = x.CasePersons
                                                                    .Where(x => x.RelationId == 1)
                                                                    .Select(x => x.Person.FirstName).FirstOrDefault(),
                                        SupervisorLastName = x.CasePersons
                                                                    .Where(x => x.RelationId == 1)
                                                                    .Select(x => x.Person.LastName).FirstOrDefault(),
                                        HouseHeadStatusId = x.HouseHeadStatusId,
                                        CaseStageId = x.CaseStageId
                                    })
                                    .FirstOrDefaultAsync();
        }

        public async Task<List<CaseListDTO>> SearchCaseList(SearchCaseDTO filters)
        {
            var query = _context.CaseBNF
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filters.CaseNumber))
            {
                var caseNumber = filters.CaseNumber.Trim();
                query = query.Where(x => x.CaseNumber != null && x.CaseNumber.Contains(caseNumber));
            }

            if (filters.RequestId.HasValue)
            {
                query = query.Where(x => x.RequestId == filters.RequestId.Value);
            }

            if (filters.FromDate.HasValue)
            {
                var fromDate = filters.FromDate.Value.Date;
                query = query.Where(x => x.CreatedDate >=  fromDate);
            }

            if (filters.ToDate.HasValue)
            {
                var toDate = filters.ToDate.Value.Date.AddDays(1);
                query = query.Where(x => x.CreatedDate < toDate);
            }

            if (!string.IsNullOrEmpty(filters.NationalCode))
            {
                var nationalCode = filters.NationalCode.Trim();
                query = query.Where(x => x.CasePersons
                                            .Any(x => x.Person.NationalCode != null &&
                                                 x.Person.NationalCode.Contains(nationalCode)));
            }

            if (!string.IsNullOrWhiteSpace(filters.SupervisorFirstName))
            {
                var firstName = filters.SupervisorFirstName.Trim();
                query = query.Where(x => x.CasePersons
                                                .Any(x => x.Person.FirstName != null &&
                                                     x.Relation.Id == 1 &&
                                                     x.Person.FirstName.Contains(firstName)));
            }

            if (!string.IsNullOrWhiteSpace(filters.SupervisorLastName))
            {
                var lastName = filters.SupervisorLastName.Trim();
                query = query.Where(x => x.CasePersons
                                                .Any(x => x.Person.LastName != null &&
                                                     x.Relation.Id == 1 &&
                                                     x.Person.LastName.Contains(lastName)));
            }

            if (filters.CaseTypeId.HasValue)
            {
                query = query.Where(x => x.CaseTypeId ==  filters.CaseTypeId.Value);
            }

            if (filters.PrivatenessStatusId.HasValue)
            {
                query = query.Where(x => x.PrivatenessStatusId == filters.PrivatenessStatusId.Value);
            }

            return await query
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new
                {
                    Case = x,
                    Supervisor = x.CasePersons
                                        .Where(x => x.Relation.Id == 1)
                                        .Select(x => x.Person)
                                        .SingleOrDefault()
                })
                .Select(x => new CaseListDTO
                {
                    Id = x.Case.Id,

                    CaseNumber = x.Case.CaseNumber ?? string.Empty,

                    RequestId = x.Case.RequestId,

                    CreatedAt = x.Case.CreatedDate,

                    NationalCode = x.Supervisor.NationalCode ?? string.Empty,

                    SupervisorFirstName = x.Supervisor.FirstName ?? string.Empty,

                    SupervisorLastName = x.Supervisor.LastName ?? string.Empty,

                    HouseHeadStatusId = x.Case.HouseHeadStatusId,

                    CaseTypeId = x.Case.CaseTypeId,

                    PrivatenessStatusId = x.Case.PrivatenessStatusId
                }).ToListAsync();
        }
    }
}
