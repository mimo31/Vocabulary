using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    static class Program
    {

        public static Page[] pages;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            pages = new Page[0];
            IO.initializeData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }

        public static void addPage(Page page)
        {
            Page[] temp = new Page[pages.Length + 1];
            for(int i = 0; i < pages.Length; i++) {
                temp[i] = pages[i];
            }
            temp[temp.Length - 1] = page;
            pages = temp;
        }
    }
}
