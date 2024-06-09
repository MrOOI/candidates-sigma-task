using CRM.Sigma.Data.Context;
using CRM.Sigma.Data;
using CRM.Sigma.Services.Candidates;
using AutoMapper;

namespace CRM.Sigma.Services
{
    public class Services : IService
    {
        private readonly AppDbContext _databaseContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private ICandidateService _candidateService;

        public Services(AppDbContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _unitOfWork = new UnitOfWork(_databaseContext); 
            _mapper = mapper;
        }

        public ICandidateService CandidateService => _candidateService ?? (_candidateService = new CandidateService(_unitOfWork, _mapper ));
    }
}
