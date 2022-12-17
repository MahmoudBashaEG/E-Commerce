using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.CompanyDTO;
using E_Commerce.Core.Entities.CompanyEntity;
using E_Commerce.Core.Enums.ErrorCodes;
using E_Commerce.Core.Repository.CrossCuttingRepository;
using E_Commerce.Core.Services.CompanyServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services.CompanyServiceImplementation
{
    public class CompanyServices : ICompanyService
    {
        private readonly ICrossCuttingRepository<Company> _companyRepository;

        public CompanyServices(
            ICrossCuttingRepository<Company> companyRepository
            )
        {
            _companyRepository = companyRepository;
        }

        public async Task<OperationResult<Company>> AddCompany(AddNewCompanyModel newCompany)
        {
            try
            {
                var company = newCompany.CreateCompanyObjectFromMe();
                await _companyRepository.Add(company);
                return OperationResult<Company>.Success(company);
            }
            catch (Exception ex)
            {
                return OperationResult<Company>.Fail(HttpCodes.ServerError,SystemErrors.INTERNAL_SERVER_ERROR,ex.ToString());
            }

        }
        public async Task<OperationResult<IEnumerable<Company>>> GetAllCompanies()
        {
            try
            {
                var companies = await _companyRepository.FindAllAsync(com => true);
                return OperationResult<IEnumerable<Company>>.Success(companies);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<Company>>.Fail(HttpCodes.ServerError, SystemErrors.INTERNAL_SERVER_ERROR, ex.ToString());
            }
        }
        public async Task<OperationResult<bool>> UpdateCompany(UpdateCompanyModel updatedCompany)
        {
            try
            {
                var currentCompany = await _companyRepository.FindOneAsync(comp => comp.Id == updatedCompany.Id);

                if (currentCompany is null)
                    return OperationResult<bool>.Fail(HttpCodes.NotFound, SystemErrors.NOT_FOUND);

                var company = updatedCompany.CreateCompanyObjectFromMe(currentCompany);
                await _companyRepository.Update(company);

                return OperationResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Fail(HttpCodes.ServerError, SystemErrors.INTERNAL_SERVER_ERROR, ex.ToString());
            }
        }
    }
}
