using Application.Interfaces;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Application.Services
{
    public class XmlConverter : IXmlConverter
    {
        public Task<List<T>> Convert<T>(string response) where T : class
        {
            using var reader = new StreamReader(response);
            XDocument xmlDocument = XDocument.Load(reader);

            var listOfData = xmlDocument.Descendants("dane").ToList();
            List<T> osPrawnaList = new List<T>();

            if (listOfData != null)
            {              
                foreach (var item in listOfData)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    using var readerString = new StreamReader(item.ToString());
                    T result = (T)xmlSerializer.Deserialize(readerString);
                    osPrawnaList.Add(result);
                }
            }
            return Task.FromResult(new List<T>());
        }
    }
}
