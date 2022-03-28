using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain.Entities
{
    [XmlType("dane")]
    public class osPrawnaPkd
    {
        [XmlElement(ElementName = "praw_pkdKod")]public string? Kod { get; set; }
        [XmlElement(ElementName = "praw_pkdNazwa")] public string? Nazwa { get; set; }
        [XmlElement(ElementName = "praw_pkdPrzewazajace")] public string? JestPrzewazajace { get; set; }
    }
}
