using Application.Interfaces;
using ConnectedServiceReference;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Application.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private string _idSession;
        public AuthorizationService()
        {
            _idSession = "";
        }

        public bool Login(string key, UslugaBIRzewnPublClient gusService)
        {
            _idSession = gusService.Zaloguj(key);

            if (String.IsNullOrEmpty(_idSession)) return false;

            //3.2  Mechanizm uwierzytelniania klienta i obsługi sesji (dokumentacja)
            OperationContextScope scope = new OperationContextScope(gusService.InnerChannel);
            HttpRequestMessageProperty requestProperties = new HttpRequestMessageProperty();
            requestProperties.Headers.Add("sid", _idSession);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestProperties;
            return true;
        }

        public void Logout(UslugaBIRzewnPublClient gusService)
        {
            gusService.Wyloguj(_idSession);
        }
    }
}
