using AutoMapper;
using CRM.Sigma.Data.Domain.Candidates;
using CRM.Sigma.Business.Models.CandidateModels;

namespace CRM.Sigma.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()   
        {
            CreateMap<CandidateModel, Candidate>();
            CreateMap<Candidate, CandidateModel>();            
        }
    }
}
