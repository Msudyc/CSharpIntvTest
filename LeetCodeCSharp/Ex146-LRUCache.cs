/*
Design and implement a data structure for Least Recently 
Used (LRU) cache. It should support the following operations:
get and set. 

get(key) - Get the value (will always be positive) of the
key if the key exists in the cache, otherwise return -1.

set(key, value) - Set or insert the value if the key is 
not already present. When the cache reached its capacity,
it should invalidate the least recently used item before
inserting a new item. 

class LRUCache{
public:
    LRUCache(int capacity) {
        
    }
    
    int get(int key) {
        
    }
    
    void set(int key, int value) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex146
    {
        public class Ex146LRUCache
        {
            //private int size;
            //private LinkedList<Tuple<int, int>> cacheList = new LinkedList<Tuple<int, int>>();
            //private Dictionary<int, LinkedListNode<Tuple<int, int>>> map = 
            //    new Dictionary<int, LinkedListNode<Tuple<int, int>>>();

            public Ex146LRUCache(int capacity)
            {
                throw new NotImplementedException();
            }

            public int Get(int key)
            {
                throw new NotImplementedException();
            }

            public void Set(int key, int value)
            {
                throw new NotImplementedException();
            }

            private void CheckCapacity()
            {
                throw new NotImplementedException();
            }
        }
    }
}