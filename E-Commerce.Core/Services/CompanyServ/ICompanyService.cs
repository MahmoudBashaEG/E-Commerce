using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.CompanyDTO;
using E_Commerce.Core.Entities.CompanyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Services.CompanyServ
{
    public interface ICompanyService
    {
        Task<OperationResult<Company>> AddCompany(AddNewCompanyModel newCompany);
        Task<OperationResult<bool>> UpdateCompany(UpdateCompanyModel updatedCompany);
        Task<OperationResult<IEnumerable<Company>>> GetAllCompanies();
    }
}
