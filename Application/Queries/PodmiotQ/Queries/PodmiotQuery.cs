using Domain.Entities;
using MediatR;

namespace Application.Queries.PodmiotQ.Queries
{
    public class PodmiotQuery : BaseQuery, IRequest<Podmiot>
    {
        public string? Regon { get; set; }
        public string? Nip { get; set; }
        public string? StatusNip { get; set; }
        public string? Nazwa { get; set; }
    }
}
