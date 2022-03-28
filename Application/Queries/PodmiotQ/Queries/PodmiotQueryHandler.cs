using MediatR;
using Domain.Entities;

namespace Application.Queries.PodmiotQ.Queries
{
    public class PodmiotQueryHandler : IRequestHandler<PodmiotQuery, Podmiot>
    {
        public Task<Podmiot> Handle(PodmiotQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
