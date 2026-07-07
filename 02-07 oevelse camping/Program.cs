using _02_07_øvelse_camping.Models;
//Jeg vil lave en ny bruger / user, (klassen er kaldt Users).
//Så jeg navngav den første bruger "Camper1" og fortalte programmet at det er en ny bruger: new Users
Users Camper1 = new Users();

Tusch roedTusch = new Tusch("Rød");
Tusch sortTusch = new Tusch("Sort");
Tusch blaaTusch = new Tusch("Blå");
Pencil HB3 = new Pencil(3, "HB3");
blaaTusch.Farve = "Blå"; // Ændrer farven på blaaTusch til "Blå"

List<IWritable> skriveredskaber = new List<IWritable>();
skriveredskaber.Add(sortTusch);
skriveredskaber.Add(blaaTusch);
skriveredskaber.Add(roedTusch);
skriveredskaber.Add(HB3);

for(int i = 0; i < skriveredskaber.Count; i++)
{
    if (skriveredskaber[i] == roedTusch)
    {
        Console.WriteLine($"Den røde blev fundet i position {i}");
    }
    else
    {
        Console.WriteLine($"Den er ikke rød i position {i}");
    }
    skriveredskaber[i].Write($"Dette er et eksempel på at skrive med {skriveredskaber[i].GetType().Name}");
}