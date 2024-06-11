using AutoMapper;
using CRM.Sigma.Data;

namespace CRM.Sigma.Business
{
    public abstract class BaseService
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected IMapper Mapper { get; }

        public BaseService(IUnitOfWork unitOfWOrk, IMapper mapper)
        {
            UnitOfWork = unitOfWOrk;   
            Mapper = mapper;
        }
    }
}
