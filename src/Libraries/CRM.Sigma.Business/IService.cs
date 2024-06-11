using CRM.Sigma.Business.Candidates;

namespace CRM.Sigma.Business
{
    public interface IService
    {
        ICandidateService CandidateService { get; }
    }
}
