using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.person.Single
{
    public class PersonSingleDTO
    {
        public int Id { get; set; }
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Mobile { get; set; }
        public string HomeNumber { get; set; }
        public int GenderId { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShenasnamehNumber { get; set; }
        public string ShenasnamehSeries { get; set; }
        public int BirthProvinceId { get; set; }
        public int BirthCityId { get; set; }
        public int MaritalStatusId { get; set; }
        public int NationalityId { get; set; }
        public int ReligonId { get; set; }
        public int JobId { get; set; }
        public int SkillId { get; set; }
        public string Interest { get; set; }
        public string Wish { get; set; }
        public int DependancyStatusId { get; set; }
        public int EducationStatusId { get; set; }
        public int EducationLevelId { get; set; }
        public string AverageScore { get; set; }
        public int OrphanStatusId { get; set; }
        public string Income { get; set; }
        public string IncomeDesc { get; set; }
        public int PhysicalStatusId { get; set; }
        public string SicknessType { get; set; }
        public int EmploymentStatusId { get; set; }
        public int UnemploymentReasonId { get; set; }
        public int SadatStatusId { get; set; }
    }
}
