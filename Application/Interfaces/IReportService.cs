using ConnectedServiceReference;

namespace Application.Interfaces
{
    public interface IReportService
    {
        public string GetReport(string regon, string nazwaRaportu, UslugaBIRzewnPublClient gusService);
    }
}
