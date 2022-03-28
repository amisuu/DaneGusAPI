using Domain.Entities;
using MediatR;

namespace Application.Queries.OsobaPrawnaPkd.Queries
{
    public class osPrawnaPkdQuery : BaseQuery, IRequest<osPrawnaPkd>
    {
        public string? Kod { get; set; }
        public string? Nazwa { get; set; }
    }
}
