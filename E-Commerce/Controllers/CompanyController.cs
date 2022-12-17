using E_Commerce.Core.API;
using E_Commerce.Core.DTOs.CompanyDTO;
using E_Commerce.Core.Enums.ErrorCodes;
using E_Commerce.Core.Services.CompanyServ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerProcess
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("AddCompany")]
        [ProducesResponseType(typeof(bool), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(bool), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> AddCompany([FromBody] AddNewCompanyModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _companyService.AddCompany(model);
            return this.ProccessResult(res);
        }

        [HttpGet("GetAllCompanies")]
        [ProducesResponseType(typeof(bool), (int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(bool), (int)HttpCodes.ServerError)]
        public async Task<IActionResult> GetAllCompanies()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _companyService.GetAllCompanies();
            return this.ProccessResult(res);
        }

        [HttpPut("UpdateCompany")]
        [ProducesResponseType(typeof(bool),(int)HttpCodes.Succeded)]
        [ProducesResponseType(typeof(bool),(int)HttpCodes.NotFound)]
        [ProducesResponseType(typeof(bool),(int)HttpCodes.ServerError)]
        public async Task<IActionResult> UpdateCompany([FromBody] UpdateCompanyModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _companyService.UpdateCompany(model);
            return this.ProccessResult(res);
        }
    }
}
