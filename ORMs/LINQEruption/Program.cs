List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//1.
// Eruption firstChileEruption = eruptions.FirstOrDefault(first => first.Location == "Chile");
// if(firstChileEruption != null)
// {
//     Console.WriteLine(firstChileEruption.ToString());
// }

// //2.
// Eruption firstHawaiianIsEruption = eruptions.FirstOrDefault(first => first.Location == "Hawaiian Is");
// if(firstHawaiianIsEruption != null)
// {
//     Console.WriteLine(firstHawaiianIsEruption.ToString());
// }
// else
// {
//     Console.WriteLine("No Hawaiian Is Eruption found.");
// }

//3.
// Eruption firstGreenlandEruption = eruptions.FirstOrDefault(first => first.Location == "Greenland");
// if(firstGreenlandEruption != null)
// {
//     Console.WriteLine(firstGreenlandEruption.ToString());
// }
// else
// {
//     Console.WriteLine("No Greenland Eruption found.");
// }

//4.
// Eruption firstNewZealandEruption = eruptions.FirstOrDefault(first => first.Location == "New Zealand" && first.Year > 1900);
// if(firstNewZealandEruption != null)
// {
//     Console.WriteLine(firstNewZealandEruption.ToString());
// }

//5.
// IEnumerable<Eruption> highElevations = eruptions.Where(height => height.ElevationInMeters > 2000);
// PrintEach(highElevations, "Eruptions higher than 2000m.");

//6.
// IEnumerable<Eruption> lVolcanos = eruptions.Where(l => l.Volcano.StartsWith('L') == true);
// PrintEach(lVolcanos, "Eruptions by volcano's starting with 'l'.");

//7.
Eruption maxElevation = eruptions.OrderByDescending(m => m.ElevationInMeters).FirstOrDefault();
// Console.WriteLine(maxElevation);
//I did this instead of max because I was having trouble figuring out how to deal with this error:
//Cannot implicitly convert type 'int' to 'Eruption' since Max returns an integer
//Instead sorted it so the highest elevation would be first, then picked the first one

//8.
Console.WriteLine(maxElevation.Volcano);

//9.







// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

