using Application.Interfaces;
using ConnectedServiceReference;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WcfCoreMtomEncoder;

namespace Application.Services
{
    public class Binding : IBinding
    {
        public void Bind(UslugaBIRzewnPublClient gus)
        {
            NetHttpBinding binding = new NetHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            binding.MessageEncoding = NetHttpMessageEncoding.Mtom;

            //var encoding = new MtomMessageEncodingBindingElement();
            //var transport = new HttpsTransportBindingElement();

            //var bindingCustom = new CustomBinding(encoding, transport);

            gus.Endpoint.Binding = binding;
        }    
    }
}
