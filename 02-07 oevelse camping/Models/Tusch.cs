using System;
using System.Collections.Generic;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    public class Tusch : IWritable

    {
        public string Farve { get; set; }

        // Constructor to initialize the Farve property
        public Tusch(string farve)
        {
            Farve = farve;
        }
        public void Write(string tekst)
        {
            Console.WriteLine($"Skriver med {Farve} tusch: {tekst}");
        }
    }
}
