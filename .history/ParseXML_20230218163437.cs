using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA
{
    public static class ParseXML
    {
        public static void ReadXML()
        { 
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
         
        }
        public class Folders
        {
            public static IEnumerable<string> FolderNames(string xml, char startingLetter)
            {
                List<string> s = new List<string>();
                XDocument doc = new XDocument(xml);
                foreach (var item in doc.Elements("folder").Elements())
                {
                    if(item.Attribute("name").Value.StartsWith(startingLetter)){
                            s.Add(item.Attribute("name").Value);
                    }
                    
                    
                }

                return s;
            }
        }
    }
}