using MaktabTaha.Domain.Common;
using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites
{
    public class Person : BaseEntity<int>
    {
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Mobile { get; set; }
        public string HomeNumber { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShenasnamehNumber { get; set; }
        public string ShenasnamehSeries { get; set; }
        public int BirthProvinceId { get; set; }
        public Province BirthProvince { get; set; }
        public int BirthCityId { get; set; }
        public City BirthCity { get; set; }
        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public int ReligonId { get; set; }
        public Religon Religon { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public string Interest { get; set; }
        public string Wish { get; set; }
        public int DependancyStatusId { get; set; }
        public DependancyStatus DependancyStatus { get; set; }
        public int EducationStatusId { get; set; }
        public EducationStatus EducationStatus { get; set; }
        public int EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public string AverageScore { get; set; }
        public int OrphanStatusId { get; set; }
        public OrphanStatus OrphanStatus { get; set; }
        public string Income { get; set; }
        public string IncomeDesc { get; set; }
        public int PhysicalStatusId { get; set; }
        public PhysicalStatus PhysicalStatus { get; set; }
        public string SicknessType { get; set; }
        public int EmploymentStatusId { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public int UnemploymentReasonId { get; set; }
        public UnemploymentReason UnemploymentReason { get; set; }

        // وضعیت سادات
        public int SadatStatusId { get; set; }
        public CaseType SadatStatus { get; set; }
        public List<Attachments> Attachments { get; set; } = new List<Attachments>();

    }
}
