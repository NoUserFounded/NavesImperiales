using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NavesImperialesModels
{
    [XmlRoot("TechnicalInfo")]
    public class TechnicalInfo
    {
        [XmlArray("InfoOptions")]
        [XmlArrayItem("InfoOption")]
        public List<InfoOption> InfoOptions { get; set; }

        [XmlArray("InfoDetails")]
        [XmlArrayItem("InfoDetail")]
        public List<InfoDetail> InfoDetails { get; set; }
    }

    public class InfoDetail
    {
        public string title { get; set; }
        public string pdfFile { get; set; }
        public string Blueprint { get; set; }
        public int idInfoDetail { get; set; }
        public string GeneralView { get; set; }
        public string textInfoDetail { get; set; }
        public string FrontView { get; set; }
        public string SideView { get; set; }
        public string TopView { get; set; }
        public string RearView { get; set; }
        public string View360 { get; set; }
        public InfoDetailData Data { get; set; }
    }
    public class InfoDetailData
    {
        public string Manufacturer { get; set; }
        public string Length { get; set; }
        public string Speed { get; set; }
        public string Hyperdrive { get; set; }
        public string Shielding { get; set; }
        public string Armament { get; set; }
    }


    public class InfoOption
    {
        public int idOption { get; set; }
        public string textOption { get; set; }
        public string icon { get; set; }
        public string Blueprint { get; set; }
        public string video { get; set; }
        public string pdfFile { get; set; }

        // Información técnica adicional (puede variar)
        [XmlArray("Details")]
        [XmlArrayItem("Detail")]
        public List<string> Details { get; set; }
    }
}
