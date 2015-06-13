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
    public partial class SearchForm : Form
    {

        ResultIndexInfo[] indexInfo = new ResultIndexInfo[0];

        private class ResultIndexInfo
        {

            Boolean isPage { get; set; }
            int pageIndex { get; set; }
            int wordIndex { get; set; }

            public ResultIndexInfo(Boolean isPage, int pageIndex, int wordIndex)
            {
                this.isPage = isPage;
                this.pageIndex = pageIndex;
                this.wordIndex = wordIndex;
            }

        }

        private void addIndexInfo(ResultIndexInfo indexInfoToAdd)
        {
            ResultIndexInfo[] temp = new ResultIndexInfo[indexInfo.Length + 1];
            for (int i = 0; i < indexInfo.Length; i++)
            {
                temp[i] = indexInfo[i];
            }
            temp[temp.Length - 1] = indexInfoToAdd;
            indexInfo = temp;
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateResults();
        }

        private void updateResults()
        {
            results.Items.Clear();
            if (searchExpression.Text != "")
            {
                if (lookForPages.Checked)
                {
                    for (int i = 0; i < Program.pages.Length; i++)
                    {
                        if (matchesSearchExression(Program.pages[i].name))
                        {
                            results.Items.Add(Program.pages[i].name + " (Page)");
                            addIndexInfo(new ResultIndexInfo(true, i, 0));
                        }
                    }
                }
                if (lookForWords.Checked)
                {
                    for (int i = 0; i < Program.pages.Length; i++)
                    {
                        for (int j = 0; j < Program.pages[i].words.Length; j++)
                        {
                            int czechWordIndex = 0;
                            if (matchesSearchExression(Program.pages[i].words[j].inEnglish))
                            {
                                results.Items.Add(Program.pages[i].words[j].inEnglish + " - " + Program.pages[i].words[j].inCzech[0] + " (" + Program.pages[i].name + ")");
                                addIndexInfo(new ResultIndexInfo(true, i, j));
                                czechWordIndex = 1;
                            }
                            while (czechWordIndex < Program.pages[i].words[j].inCzech.Length)
                            {
                                if (matchesSearchExression(Program.pages[i].words[j].inCzech[czechWordIndex]))
                                {
                                    results.Items.Add(Program.pages[i].words[j].inEnglish + " - " + Program.pages[i].words[j].inCzech[czechWordIndex] + " (" + Program.pages[i].name + ")");
                                    addIndexInfo(new ResultIndexInfo(true, i, j));
                                }
                                czechWordIndex++;
                            }
                        }
                    }
                }
            }
        }

        private Boolean matchesSearchExression(string testString)
        {
            if (beCaseSensitive.Checked)
            {
                return testString.Contains(searchExpression.Text);
            }
            else
            {
                string loweredString = testString.ToLower();
                return loweredString.Contains(searchExpression.Text.ToLower());
            }
        }

        private void beCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            updateResults();
        }

        private void lookForPages_CheckedChanged(object sender, EventArgs e)
        {
            updateResults();
        }

        private void lookForWords_CheckedChanged(object sender, EventArgs e)
        {
            updateResults();
        }

    }
}
