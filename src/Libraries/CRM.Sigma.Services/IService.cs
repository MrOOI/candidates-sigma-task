using CRM.Sigma.Services.Candidates;

namespace CRM.Sigma.Services
{
    public interface IService
    {
        ICandidateService CandidateService { get; }
    }
}
