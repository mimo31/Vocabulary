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
        public Word[] words { get; private set; }

        public Page(string name)
        {
            this.name = name;
            this.words = new Word[0];
        }

        public void addWord(string inCzech, string inEnglish, string comment)
        {
            this.addWord(new Word(new string[] { inCzech }, inEnglish, comment));
        }

        public void addWord(string[] inCzech, string inEnglish, string comment)
        {
            this.addWord(new Word(inCzech , inEnglish, comment));
        }

        public void addWord(Word word)
        {
            Word[] temp = new Word[words.Length + 1];
            for (int i = 0; i < words.Length; i++)
            {
                temp[i] = words[i];
            }
            temp[temp.Length - 1] = word;
            this.words = temp;
        }

        public byte[] toBytes()
        {
            return new byte[0];
        }

        public Page(byte[] bytes)
        {

        }
    }

    class Word
    {
        public string[] inCzech{get; set;}
        public string inEnglish{get; set;}
        public string comment{get; set;}

        public Word(string[] inCzech, string inEnglish, string comment)
        {
            this.inCzech = inCzech;
            this.inEnglish = inEnglish;
            this.comment = comment;
        }
    }
}
