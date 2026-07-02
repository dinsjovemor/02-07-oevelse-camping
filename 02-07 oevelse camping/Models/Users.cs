using System;
using System.Collections.Generic;
using System.Text;

namespace _02_07_øvelse_camping.Models
{
    //jeg har lavet accessor til public fordi jeg vil bruge klassen et andet sted, derfor er den public så den er tilgængelig
    public class Users
    {
        //Jeg vælger at sige at når man opretter en User, så skal User indeholde; Navn mm.
        //Jeg sætter get og set til public, så jeg kan bruge det i andre klasser.
        public string Name { get; set; }
    }
}
