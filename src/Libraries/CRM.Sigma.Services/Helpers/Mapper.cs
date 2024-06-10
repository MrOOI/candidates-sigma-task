using AutoMapper;
using CRM.Sigma.Data.Domain.Candidates;
using CRM.Sigma.Services.Models.CandidateModels;

namespace CRM.Sigma.Services.Helpers
{
    public class CustomMapper : Profile
    {
        public CustomMapper() 
        {
            CreateMap<CandidateModel, Candidate>();
            CreateMap<Candidate, CandidateModel>();
        }
    }
}
