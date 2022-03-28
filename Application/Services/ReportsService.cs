using Application.Interfaces;
using ConnectedServiceReference;

namespace Application.Services
{
    public class ReportsService : IReportService
    {
        protected ParametryWyszukiwania parametrySzukania;
        public string GetReport(string regon, string nazwaRaportu, UslugaBIRzewnPublClient gusService)
        {
            var report = gusService.DanePobierzPelnyRaport(regon, nazwaRaportu);

            return report;
        }
    }
}
