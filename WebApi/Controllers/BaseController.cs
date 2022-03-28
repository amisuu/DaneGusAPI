using Application.Interfaces;
using ConnectedServiceReference;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly UslugaBIRzewnPublClient birUsluga;
        protected readonly IMediator _mediator;
        protected readonly IAuthorizationService _authorization;
        protected readonly IReportService _reportService;

        public BaseController(IMediator mediator, 
                              IAuthorizationService authorization, 
                              IBinding binding, 
                              IReportService reportService)
        {
            birUsluga = new UslugaBIRzewnPublClient();
            _mediator = mediator;
            _authorization = authorization;
            _reportService = reportService;
            binding.Bind(birUsluga);
        }
    }
}
