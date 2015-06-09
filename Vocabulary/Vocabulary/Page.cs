using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    class Page
    {

        public string name{get; set;}
        word[] words;

        public Page(string name)
        {
            name = this.name;
        }

        public void addWord(string inCzech, string inEnglish, string comment)
        {
            this.addWord(new word(new string[] { inCzech }, inEnglish, comment));
        }

        public void addWord(string[] inCzech, string inEnglish, string comment)
        {
            this.addWord(new word(inCzech , inEnglish, comment));
        }

        public void addWord(word word)
        {
            word[] temp = new word[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                temp[i] = words[i];
            }
            temp[temp.Length - 1] = word;
            words = temp;
        }

        public byte[] toBytes()
        {
            return new byte[0];
        }

        public Page(byte[] bytes)
        {

        }
    }

    class word
    {
        public string[] inCzech{get; set;}
        public string inEnglish{get; set;}
        public string comment{get; set;}

        public word(string[] inCzech, string inEnglish, string comment)
        {
            this.inCzech = inCzech;
            this.inEnglish = inEnglish;
            this.comment = comment;
        }
    }
}
