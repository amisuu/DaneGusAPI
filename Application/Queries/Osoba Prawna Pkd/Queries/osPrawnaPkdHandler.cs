using Application.Queries.OsobaPrawnaPkd.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Queries.OsobaPrawnaPkd.Queries
{
    public class osPrawnaPkdHandler : IRequestHandler<osPrawnaPkdQuery, osPrawnaPkd>
    {
        public Task<osPrawnaPkd> Handle(osPrawnaPkdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
