using ConnectedServiceReference;

namespace Application.Interfaces
{
    public interface IAuthorizationService
    {
        public bool Login(string key, UslugaBIRzewnPublClient gusService);
        public void Logout(UslugaBIRzewnPublClient gusService);
    }
}
