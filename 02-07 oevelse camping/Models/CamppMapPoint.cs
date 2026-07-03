using System;
using System.Collections.Generic;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    //Efter installation af Google Maps Location Services i NuGet: Laver jeg først klassen public 
    public class CamppMapPoint
    {
        //Jeg vælger at i klassen CamppMapPoint skal man oprette følgende: (double er valgt pga. decimaler i koordinaterne)
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
