using Application.Interfaces;
using Application.Queries.PodmiotQ.Queries;
using ConnectedServiceReference;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PodmiotController : BaseController
    {
        public PodmiotController(IMediator mediator, 
                                 IAuthorizationService authorization, 
                                 IBinding binding, 
                                 IReportService reportService) 
            : base(mediator, authorization, binding, reportService)
        {
        }

        [HttpGet("/Podmiot")]
        public async Task<ActionResult<Podmiot>> GetPodmiot(string apiKey, string nip)
        {
            if (!_authorization.Login(apiKey, birUsluga))
            {
                return Unauthorized("API Key is incorrect");
            }

            if (String.IsNullOrEmpty(nip))
            {
                return UnprocessableEntity("NIP must consisting of 10 characters");
            }        

            var request = new PodmiotQuery()
            {
                Nip = nip,
                GusClient = new UslugaBIRzewnPublClient()
            };

            var response = await _mediator.Send(request);

            if (String.IsNullOrEmpty(response.Nip))
            {
                NotFound("NIP not found");
            }

            return Ok(response);
        }

        [HttpGet("/PodmiotRaport")]
        public async Task<ActionResult<Podmiot>> GetPodmiotReport(string regon, string nazwaRaportu)
        {
            if (String.IsNullOrEmpty(regon) || String.IsNullOrEmpty(nazwaRaportu))
            {
                return UnprocessableEntity("Regon or nazwa raportu is null");
            }

            var result = _reportService.GetReport(regon, nazwaRaportu, birUsluga);

            if (String.IsNullOrEmpty(result))
            {
                return NotFound("Report not found");
            }

            return Ok(result);
        }
    }
}
