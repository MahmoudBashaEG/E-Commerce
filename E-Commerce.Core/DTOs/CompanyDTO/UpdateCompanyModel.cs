using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.DTOs.CompanyDTO
{
    public class UpdateCompanyModel
    {
        public int Id { get; set; }
        public CompanyApproveStatus CompanyStatus { get; set; }
        public short StartingHour { get; set; }
        public short EndingHour { get; set; }
        public Company CreateCompanyObjectFromMe(Company currentCompany)
        {
            return new Company()
            {
                Id = currentCompany.Id,
                CompanyName = currentCompany.CompanyName,
                CompanyStatus = this.CompanyStatus,
                EndingHour = this.EndingHour,
                StartingHour = this.StartingHour,
            };
        }
    }
}
