using System.Xml.Serialization;

namespace Domain.Entities
{
	[XmlType("dane")]
    public class osPrawna
    {
        [XmlElement(ElementName = "praw_regon9")] public string? Regon { get; set; }
		[XmlElement(ElementName = "praw_nip")] public string? Nip { get; set; }
		[XmlElement(ElementName = "praw_statusNip")] public string? StatusNip { get; set; }
		[XmlElement(ElementName = "praw_nazwa")] public string? Nazwa { get; set; }
		[XmlElement(ElementName = "praw_nazwaSkrocona")] public string? NazwaSkrocona { get; set; }
		[XmlElement(ElementName = "praw_numerWRejestrzeEwidencji")] public string? NumerWRejestrzeEwidencji { get; set; }
		[XmlElement(ElementName = "praw_dataWpisuDoRejestruEwidencji")] public string? DataWpisuDoRejestruEwidencji { get; set; }
		[XmlElement(ElementName = "praw_dataPowstania")] public string? DataPowstania { get; set; }
		[XmlElement(ElementName = "praw_dataRozpoczeciaDzialalnosci")] public string? DataRozpoczeciaDzialalnosci { get; set; }
		[XmlElement(ElementName = "praw_dataWpisuDoRegon")] public string? DataWpisuDoRegon { get; set; }
		[XmlElement(ElementName = "praw_dataZawieszeniaDzialalnosci")] public string? DataZawieszeniaDzialalnosci { get; set; }
		[XmlElement(ElementName = "praw_dataWznowieniaDzialalnosci")] public string? DataWznowieniaDzialalnosci { get; set; }
		[XmlElement(ElementName = "praw_dataZaistnieniaZmiany")] public string? DataZaistnieniaZmiany { get; set; }
		[XmlElement(ElementName = "praw_dataZakonczeniaDzialalnosci")] public string? DataZakonczeniaDzialalnosci { get; set; }
		[XmlElement(ElementName = "praw_dataSkresleniaZRegon")] public string? DataSkresleniaZRegon { get; set; }
		[XmlElement(ElementName = "praw_dataOrzeczeniaOUpadlosci")] public string? DataOrzeczeniaOUpadlosci { get; set; }
		[XmlElement(ElementName = "praw_dataZakonczeniaPostepowaniaUpadlosciowego")] public string? DataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
		[XmlElement(ElementName = "praw_adSiedzKraj_Symbol")] public string? SiedzibaKrajuSymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzWojewodztwo_Symbol")] public string? SiedzibaWojewodztwaSymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzPowiat_Symbol")] public string? SiedzibaPowiatuSymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzGmina_Symbol")] public string? SiedzibaGminySymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzKodPocztowy")] public string? SiedzibaKodPocztowy { get; set; }
		[XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Symbol")] public string? SiedzibaMiejscowoscPocztySymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzMiejscowosc_Symbol")] public string? SiedzMiejscowoscSymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzUlica_Symbol")] public string? SiedzibaUlicaSymbol { get; set; }
		[XmlElement(ElementName = "praw_adSiedzNumerNieruchomosci")] public string? SiedzibaNumerNieruchomosci { get; set; }
		[XmlElement(ElementName = "praw_adSiedzNumerLokalu")] public string? SiedzibaNumerLokalu { get; set; }
		[XmlElement(ElementName = "praw_adSiedzNietypoweMiejsceLokalizacji")] public string? SiedzibaNietypoweMiejsceLokalizacji { get; set; }
		[XmlElement(ElementName = "praw_numerTelefonu")] public string? NumerTelefonu { get; set; }
		[XmlElement(ElementName = "praw_numerWewnetrznyTelefonu")] public string? NumerWewnetrznyTelefonu { get; set; }
		[XmlElement(ElementName = "praw_adresStronyinternetowej")] public string? AdresStronyinternetowej { get; set; }
		[XmlElement(ElementName = "praw_adSiedzKraj_Nazwa")] public string? SiedzibaKrajNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzWojewodztwo_Nazwa")] public string? SiedzibaWojewodztwoNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzPowiat_Nazwa")] public string? SiedzibaPowiatNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzGmina_Nazwa")] public string? SiedzibaGminaNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzMiejscowosc_Nazwa")] public string? SiedzibaMiejscowoscNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Nazwa")] public string? SiedzibaMiejscowoscPocztyNazwa { get; set; }
		[XmlElement(ElementName = "praw_adSiedzUlica_Nazwa")] public string? SiedzibaUlicaNazwa { get; set; }
		[XmlElement(ElementName = "praw_podstawowaFormaPrawna_Symbol")] public string? PodstawowaFormaPrawnaSymbol { get; set; }
		[XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Symbol")] public string? SzczegolnaFormaPrawnaSymbol { get; set; }
		[XmlElement(ElementName = "praw_formaFinansowania_Symbol")] public string? FormaFinansowaniaSymbol { get; set; }
		[XmlElement(ElementName = "praw_formaWlasnosci_Symbol")] public string? formaWlasnosciSymbol { get; set; }
		[XmlElement(ElementName = "praw_organZalozycielski_Symbol")] public string? OrganZalozycielskiSymbol { get; set; }
		[XmlElement(ElementName = "praw_organRejestrowy_Symbol")] public string? OrganRejestrowySymbol { get; set; }
		[XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Symbol")] public string? RodzajRejestruEwidencjiSymbol { get; set; }
		[XmlElement(ElementName = "praw_podstawowaFormaPrawna_Nazwa")] public string? PodstawowaFormaPrawnaNazwa { get; set; }
		[XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Nazwa")] public string? SzczegolnaFormaPrawnaNazwa { get; set; }
		[XmlElement(ElementName = "praw_formaFinansowania_Nazwa")] public string? FormaFinansowaniaNazwa { get; set; }
		[XmlElement(ElementName = "praw_formaWlasnosci_Nazwa")] public string? FormaWlasnosciNazwa { get; set; }
		[XmlElement(ElementName = "praw_organZalozycielski_Nazwa")] public string? OrganZalozycielskiNazwa { get; set; }
		[XmlElement(ElementName = "praw_organRejestrowy_Nazwa")] public string? OrganRejestrowyNazwa { get; set; }
		[XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Nazwa")] public string? RodzajRejestruEwidencjiNazwa { get; set; }
		[XmlElement(ElementName = "praw_liczbaJednLokalnych")] public string? LiczbaJednLokalnych { get; set; }
    }
}
