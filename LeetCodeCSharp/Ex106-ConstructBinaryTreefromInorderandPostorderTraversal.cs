/*
Given inorder and postorder traversal of a tree, construct
the binary tree.

Note:
 You may assume that duplicates do not exist in the tree. 

class Solution {
public:
    TreeNode *buildTree(List<int> &inorder, List<int> &postorder) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex106
    {
        private static Dictionary<int, int> mapInorder = new Dictionary<int, int>();

        public static TreeNode BuildTree(List<int> inorder, List<int> postorder)
        {
            throw new NotImplementedException();
        }

        private static TreeNode Build(
            List<int> inorder, List<int> postorder, int sIn, int eIn, int sP, int eP)
        {
            throw new NotImplementedException();
        }
    }
}