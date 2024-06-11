using AutoMapper;
using CRM.Sigma.API.Models.Candidates;
using CRM.Sigma.Business.Models.CandidateModels;

namespace CRM.Sigma.API.Mapping
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<CandidateCreateOrUpdateRequest, CandidateModel>();
        }
        
    }
}
