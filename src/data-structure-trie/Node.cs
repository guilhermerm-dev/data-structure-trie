using System.Collections.Generic;

namespace data_structure_trie
{
    public class Node
    {
        public Node()
        {
            Children = new Dictionary<char, Node>();
        }

        public Dictionary<char, Node> Children
        {
            get;
            set;
        }

        public bool IsCompleteWord
        {
            get;
            set;
        }
    }
}
