using AutoMapper;
using CRM.Sigma.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Sigma.API.Controllers
{
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
        public BaseController(IService service, IMapper mapper)
        {
            Service = service;
            Mapper = mapper;
        }
        public IService Service { get; private set; }
        public IMapper Mapper { get; private set; }
    }
}