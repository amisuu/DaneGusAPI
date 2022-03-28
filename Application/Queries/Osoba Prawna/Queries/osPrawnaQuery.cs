using MediatR;
using Domain.Entities;

namespace Application.Queries.OsobaPrawna.Queries
{
    public class osPrawnaQuery : BaseQuery, IRequest<osPrawna>
    {
        public string? Regon { get; set; }
        public string? Nip { get; set; }
        public string? Nazwa { get; set; }
        public string? StatusNip { get; set; }
    }
}
