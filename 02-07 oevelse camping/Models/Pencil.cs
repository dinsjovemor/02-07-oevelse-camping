using System;
using System.Collections.Generic;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    public class Pencil : IWritable
    { 
        public int PencilThickness { get; set; }
        public string PencilName { get; set; }
        public Pencil(int pencilThickness, string pencilName)
        { 
            PencilThickness = pencilThickness;
            PencilName = pencilName;
        }
        public void Write(string tekst)
        {
            Console.WriteLine($"Skriver med blyant {PencilName}: {tekst}");
        }
    }
}
