using System;
using System.Collections.Generic;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    //jeg har lavet accessor til public fordi jeg vil bruge klassen et andet sted, derfor er den public så den er tilgængelig
    public class Campsites
    {
        //Jeg vælger at i klassen Campsites skal man oprette følgende properties; CampSiteName mm.
        public string CampSiteName { get; set; }
        public string CampSiteAdress { get; set; }
        public int CampSiteAdressNumber {  get; set; }
        public string CampSiteCity { get; set; }
        public int CampSiteZipCode { get; set; }
        public string CampSiteRegion { get; set; }
        public string CampSiteCountry { get; set; }
    


    }
}
