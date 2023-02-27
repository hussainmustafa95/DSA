using System.Globalization;
using System.Xml.Linq;
using DSA;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
WallsAndGatesSol.Run();

 string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        XDocument xdoc = XDocument.Parse(xml);
        
      var result = (from c in xdoc.Elements("folder").Elements("folder").Elements("folder")
                    
                    select c).ToList();


      return null;
    }


}


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