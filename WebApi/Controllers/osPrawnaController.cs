using Application.Interfaces;
using Application.Queries.OsobaPrawna.Queries;
using ConnectedServiceReference;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class osPrawnaController : BaseController
    {
        public osPrawnaController(IMediator mediator,
                                 IAuthorizationService authorization,
                                 IBinding binding,
                                 IReportService reportService)
            : base(mediator, authorization, binding, reportService)
        {
        }

        [HttpGet]
        public async Task<ActionResult<osPrawna>> GetOsobaPrawna(string apiKey, string regon)
        {
            if (!_authorization.Login(apiKey, birUsluga))
            {
                return Unauthorized("API Key is incorrect");
            }

            if (String.IsNullOrEmpty(regon))
            {
                return UnprocessableEntity("REGON must have 9 characters");
            }      

            var request = new osPrawnaQuery()
            {
                Regon = regon,
                GusClient = new UslugaBIRzewnPublClient()
            };

            var response = await _mediator.Send(request);

            if (String.IsNullOrEmpty(response.Regon))
            {
                return NotFound("Not found regon");
            }

            return Ok(response);
        }
    }
}
