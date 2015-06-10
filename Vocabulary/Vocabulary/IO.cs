using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    static class IO
    {

        const string parentDirectory = "C:\\Vocabulary";

        public static void initializeData()
        {
            if(Directory.Exists(parentDirectory)) {
                string[] pageFiles = Directory.GetFiles(parentDirectory);
                foreach(string file in pageFiles) {
                    Program.addPage(new Page(File.ReadAllBytes(file)));
                }
            }
            else
            {
                Directory.CreateDirectory(parentDirectory);
            }
        }
    }
}
