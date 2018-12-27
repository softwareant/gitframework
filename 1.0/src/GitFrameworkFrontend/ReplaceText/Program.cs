using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReplaceText
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SHould be Run Like ReplaceText <FROMTEXT> <TOTEXT> <Directory> <Filter -Optional)
            if (args.Count() == 4 || args.Count() == 5)
            {
                // Read Command line params to variables
                ReplaceText.Config config = new ReplaceText.Config(args);

                // Get All Files to be processed into an ArrayList
                ArrayList fileToProcess = FindFilesToProcess(config.Directory, config.Filter);

                //if (File.Exists )
            }
            else
            {
                string strMessage = "USAGE: " + System.AppDomain.CurrentDomain.FriendlyName + " <FROMTEXT> <TOTEXT> <Directory> <Filter - Optional>";
                Console.WriteLine(strMessage);
            }

        }

        private static ArrayList FindFilesToProcess(string directory, string filter)
        {
            //if (File.exists)
            return null;
        }

        private static void ReplaceText(string filename, string fromText, string toText)
        {
            string content = File.ReadAllText(filename);
            content = content.Replace(fromText, toText);
            File.WriteAllText(filename, content);
        }
    }
}
