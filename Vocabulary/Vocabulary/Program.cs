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
            int pageListIndex;
            {
                int i = 0;
                while (i < pages.Length)
                {
                    if (string.Compare(pages[i].name, page.name) > 0)
                    {
                        break;
                    }
                    i++;
                }
                pageListIndex = i;
            }
            Page[] temp = new Page[pages.Length + 1];
            for (int i = 0; i < pageListIndex; i++)
            {
                temp[i] = pages[i];
            }
            temp[pageListIndex] = page;
            for (int i = pageListIndex; i < pages.Length; i++)
            {
                temp[i + 1] = pages[i];
            }
            pages = temp;
        }
    }
}
