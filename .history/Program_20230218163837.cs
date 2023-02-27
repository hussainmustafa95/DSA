using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using DSA;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WallsAndGatesSol.Run();




public class Account
{
    public enum Writer{
        Submit,
        Modify
    }
    public enum Editor{
        Delete,
        Publish, 
        Comment
    }
    public enum Owner{
        Writer,
        Editor
    }

    [Flags]
    public enum Access
    {
      Writer,
      Editor,
      Owner,

       Delete,
        Publish,
        Submit,
        Comment,
        Modify
    }
    
    public static void Main(string[] args)
    {       
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}