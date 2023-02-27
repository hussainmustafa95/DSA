
using DSA;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///WallsAndGatesSol.Run();

// ParseXML.ReadXML();
//TrainComposition.Main();

string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); 

Console.Read();
static string[] UniqueNames(string[] names1, string[] names2)
{
    return names1.Union(names2).ToArray<string>();;
}