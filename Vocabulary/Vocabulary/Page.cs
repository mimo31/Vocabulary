using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vocabulary
{
    class Page
    {

        public string name { get; set; }
        public Word[] words { get; private set; }
        public Boolean changed;

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
            this.addWord(new Word(inCzech, inEnglish, comment));
        }

        public void addWord(Word word)
        {
            int newWordIndex;
            {
                int i = 0;
                while (i < words.Length)
                {
                    if (String.Compare(words[i].inEnglish, word.inEnglish) > 0)
                    {
                        break;
                    }
                    i++;
                }
                newWordIndex = i;
            }
            Word[] temp = new Word[words.Length + 1];
            for (int i = 0; i < newWordIndex; i++)
            {
                temp[i] = words[i];
            }
            temp[newWordIndex] = word;
            for (int i = newWordIndex; i < words.Length; i++)
            {
                temp[i + 1] = words[i];
            }
            words = temp;
            changed = true;
        }

        public byte[] Serialiaze()
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(ms);
            writer.Write(name);
            writer.Write(words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                byte[] wordBytes = words[i].Serialize();
                writer.Write(wordBytes.Length);
                writer.Write(wordBytes);
            }
            byte[] bytesToReturn = ms.ToArray();
            writer.Close();
            ms.Close();
            return bytesToReturn;
        }

        public Page(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            BinaryReader reader = new BinaryReader(ms);
            name = reader.ReadString();
            words = new Word[reader.ReadInt32()];
            for (int i = 0; i < words.Length; i++)
            {
                Int32 nextWordByteLength = reader.ReadInt32();
                words[i] = new Word(reader.ReadBytes(nextWordByteLength));
            }
            reader.Close();
            ms.Close();
        }
    }

    class Word
    {
        public string[] inCzech { get; set; }
        public string inEnglish { get; set; }
        public string comment { get; set; }

        public Word(string[] inCzech, string inEnglish, string comment)
        {
            this.inCzech = inCzech;
            this.inEnglish = inEnglish;
            this.comment = comment;
        }

        public byte[] Serialize()
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(ms);
            writer.Write(inCzech.Length);
            for (int i = 0; i < inCzech.Length; i++)
            {
                writer.Write(inCzech[i]);
            }
            writer.Write(inEnglish);
            writer.Write(comment);
            return ms.ToArray();
        }

        public Word(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            BinaryReader reader = new BinaryReader(ms);
            inCzech = new string[reader.ReadInt32()];
            for (int i = 0; i < inCzech.Length; i++)
            {
                inCzech[i] = reader.ReadString();
            }
            inEnglish = reader.ReadString();
            comment = reader.ReadString();
        }
    }
}
