using Application.Interfaces;
using Application.Queries.OsobaPrawna.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Queries.Osoba_Prawna.Queries
{
    public class osPrawnaHandler : IRequestHandler<osPrawnaQuery, osPrawna>
    {
        private readonly IXmlConverter _xmlConverter;

        public osPrawnaHandler(IXmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }
        public async Task<osPrawna> Handle(osPrawnaQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var osobaPrawna = (await request.GusClient.DanePobierzPelnyRaportAsync(request.Regon, request.Nazwa))
                    .DanePobierzPelnyRaportResult;

                if (String.IsNullOrEmpty(osobaPrawna)) return new osPrawna();

                return (await _xmlConverter.Convert<osPrawna>(osobaPrawna)).First();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }
    }
}
