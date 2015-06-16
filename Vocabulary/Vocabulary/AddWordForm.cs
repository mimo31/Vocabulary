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
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void updateComboBox()
        {
            pageComboBox.Items.Clear();
            for (int i = 0; i < Program.pages.Length; i++)
            {
                if (Program.pages[i].name.ToLower().Contains(pageComboBox.Text.ToLower()))
                {
                    pageComboBox.Items.Add(Program.pages[i].name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pageIndex = -1;
            for (int i = 0; i < Program.pages.Length; i++)
            {
                if (Program.pages[i].name == pageComboBox.Text)
                {
                    pageIndex = i;
                    break;
                }
            }
            if (pageIndex != -1)
            {
                int numberOfCzechExpressions = 1;
                foreach (char ch in CzechTextBox.Text)
                {
                    if (ch == ',')
                    {
                        numberOfCzechExpressions++;
                    }
                }
                string[] CzechExpressions = new string[numberOfCzechExpressions];
                int nextExpressionIndex = 0;
                for (int i = 0; i < CzechTextBox.Text.Length; i++)
                {
                    if (CzechTextBox.Text[i] == ',')
                    {
                        CzechExpressions[nextExpressionIndex] = removeWhiteSpace(CzechTextBox.Text.Substring(0, i));
                        nextExpressionIndex++;
                        CzechTextBox.Text = CzechTextBox.Text.Substring(i + 1);
                        i = -1;
                    }
                }
                CzechExpressions[CzechExpressions.Length - 1] = removeWhiteSpace(CzechTextBox.Text);
                string EnglishExpression = removeWhiteSpace(EnglishTextBox.Text);
                string comment = removeWhiteSpace(commentTextBox.Text);
                Program.pages[pageIndex].addWord(CzechExpressions, EnglishExpression, comment);
                this.Close();
            }
            else
            {
                MessageBox.Show("There is not a page called " + pageComboBox.Text + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string removeWhiteSpace(string str)
        {
            if (str != "")
            {
                while (str[0] == ' ')
                {
                    str = str.Substring(1);
                }
                while (str[str.Length - 1] == ' ')
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }
            return str;
        }

        private void pageComboBox_TextChanged(object sender, EventArgs e)
        {
            if (pageComboBox.DroppedDown)
            {
                updateComboBox();
            }               
        }
    }
}
