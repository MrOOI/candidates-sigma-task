using AutoMapper;
using CRM.Sigma.API.Models.Candidates;
using CRM.Sigma.Business;
using CRM.Sigma.Business.Models.CandidateModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Sigma.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class CandidateController : BaseController
    {
        public CandidateController(IService service, IMapper mapper) : base(service, mapper)
        {
        }

        [HttpPost("candidate/create")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateOrUpdate (CandidateCreateOrUpdateRequest requestModel)
        {
            var candidateModel = Mapper.Map<CandidateModel>(requestModel);
            var result = await Service.CandidateService.CreateOrUpdateAsync(candidateModel);

            return Ok(result);
        }

        [HttpGet("candidates/get-all")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll([FromQuery] CandidateFilterParams filterParams)
        {
            var result = await Service.CandidateService.GetAllAsync(filterParams);

            return Ok(result.ToPagedListData());
        }
    }
}
