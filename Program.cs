
using DSA;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///WallsAndGatesSol.Run();

// ParseXML.ReadXML();
//TrainComposition.Main();

int n = 9;

var s = Convert.ToString(n, 2);

Console.WriteLine(s);
int count = 0;
int maxCount =0;

for (int i = 0; i < s.Length; i++)
{
    if(s[i]==0){
        count ++;
    }
    else{
        count = 0;

        maxCount  = Math.Max(count, maxCount);
    }
}
Console.Read();