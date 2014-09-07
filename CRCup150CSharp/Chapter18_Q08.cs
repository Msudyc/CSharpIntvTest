/* Question 18.8
 
Given a string s and an array of smaller string T, design a method to search s for each small string in T. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q08
    {
        public class SuffixTree
        {
            private SuffixTreeNode root = new SuffixTreeNode();
            public SuffixTree(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    string suffix = s.Substring(i);
                    this.root.InsertString(suffix, i);
                }
            }

            public List<int> Search(string s)
            {
                return this.root.Search(s);
            }
        }

        public class SuffixTreeNode
        {
            private Dictionary<char, SuffixTreeNode> children = new Dictionary<char, SuffixTreeNode>();
            private List<int> indexes = new List<int>();
            //private char value;

            public void InsertString(string s, int index)
            {
                throw new NotImplementedException();
            }

            public List<int> Search(string s)
            {
                throw new NotImplementedException();
            }
        }
    }
}
