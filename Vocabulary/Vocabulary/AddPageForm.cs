using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary
{
    public partial class AddPageForm : Form
    {
        public AddPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean sameNameDetected = false;
            for (int i = 0; i < Program.pages.Length; i++)
            {
                if (Program.pages[i].name == pageNameTextbox.Text)
                {
                    sameNameDetected = true;
                    break;
                }
            }
            if (sameNameDetected)
            {
                MessageBox.Show("There is aleready a page called " + pageNameTextbox.Text + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Program.addPage(new Page(pageNameTextbox.Text));
                this.Close();
            }
        }
    }
}
