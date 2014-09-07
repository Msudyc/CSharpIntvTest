/* Question 18.13
 
Given a list of millions of words, design an algorithm to create the largest possible rectangle of 
letters such that every row forms a word (reading left to right) and every column forms a word 
(reading top to bottom). The word need not be chosed consecutively from the list, but all rows 
must be the same length and all columns must be the same height. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q13
    {
        //private int maxWordLength;
        //private WordGroup[] groupList;
        //private Trie[] trieList;

        public Chapter18_Q13(string[] list)
        {
            throw new NotImplementedException();
        }

        public Rectangle MakeRectangle()
        {
            throw new NotImplementedException();
        }

        private Rectangle MakeRectangle(int l, int h)
        {
            throw new NotImplementedException();
        }

        private Rectangle MakePartialRectangle(int l, int h, Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public class Rectangle
        {
            public int Height { get; set; }
            public int Length { get; set; }
            public char[,] Matrix { get; set; }

            public Rectangle(int len)
            {
                this.Length = len;
            }

            public Rectangle(char[,] letters)
            {
                this.Height = letters.GetLength(0);
                this.Length = letters.GetLength(1);
                this.Matrix = letters;
            }

            public char GetLetter(int i, int j) { return this.Matrix[i, j]; }

            public string GetColumn(int c)
            {
                char[] column = new char[this.Height];
                for (int i = 0; i < this.Height; i++)
                    column[i] = this.GetLetter(i, c);
                return new string(column);
            }

            public bool IsComplete(int l, int h, WordGroup groupList)
            {
                if (this.Height == h)
                {
                    for (int i = 0; i < l; i++)
                    {
                        string col = this.GetColumn(i);
                        if (!groupList.ContainsWord(col))
                            return false;
                    }

                    return true;
                }

                return false;
            }

            public bool IsPartialOK(int l, Trie trie)
            {
                if (this.Height == 0)
                    return true;
                for (int i = 0; i < l; i++)
                {
                    string col = this.GetColumn(i);
                    if (!trie.Contains(col))
                        return false;
                }

                return true;
            }

            public Rectangle Append(string s)
            {
                if (s.Length == this.Length)
                {
                    char[,] temp = new char[this.Height + 1, this.Length];
                    for (int i = 0; i < this.Height; i++)
                        for (int j = 0; j < this.Length; j++)
                            temp[i, j] = this.Matrix[i, j];

                    for (int i = 0; i < this.Length; i++)
                        temp[this.Height, i] = s[i];

                    return new Rectangle(temp);
                }

                return null;
            }
        }

        public class WordGroup
        {
            private Dictionary<string, bool> lookup = new Dictionary<string, bool>();
            private List<string> group = new List<string>();

            public bool ContainsWord(string s)
            {
                return lookup.ContainsKey(s);
            }

            public void AddWord(string s)
            {
                this.group.Add(s);
                this.lookup.Add(s, true);
            }

            public int Length { get { return this.group.Count; } }
            public string GetWord(int i) { return this.group[i]; }
            public List<string> GetWords() { return this.group; }

            public static WordGroup[] Create(string[] list)
            {
                int maxWordLength = 0;

                foreach (string s in list)
                    if (s.Length > maxWordLength)
                        maxWordLength = s.Length;

                WordGroup[] result = new WordGroup[maxWordLength];
                foreach (string s in list)
                {
                    int len = s.Length - 1;
                    if (result[len] == null)
                        result[len] = new WordGroup();
                    result[len].AddWord(s);
                }

                return result;
            }
        }
    }
}
