using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.DTOs.CompanyDTO
{
    public class UpdateCompanyModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public CompanyApproveStatus CompanyStatus { get; set; }
        
        [Required]
        public short StartingHour { get; set; }
        
        [Required]
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
