using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    //Efter installation af Google Maps Location Services i NuGet: Laver jeg først klassen public 
    public class MapPoint
    {
        //Jeg vælger at i klassen skal man oprette Længde og Breddegrader
        //Datatypen double er valgt pga. decimaler i koordinaterne
        //Required attributten sikrer, at Latitude og Longitude skal udfyldes,
        //for at undgå situationer, hvor enten at lokationsdataene ikke er udfyldt, eller hvor lokationsdataene er inkorrekt 
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
