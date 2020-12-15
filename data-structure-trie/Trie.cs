using System.Collections.Generic;

namespace data_structure_trie
{
    public struct Trie
    {
        private readonly Node Root;

        public void Insert(string word)
        {
            Node current = Root;
            char[] characteres = word.ToCharArray();
            foreach (char c in characteres)
            {
                Node child = current.Children.GetValueOrDefault(c);
                if (child is null)
                    child.Children.Add(c, new Node());
                current = child;
            }
            current.IsCompleteWord = true;
        }

        public bool Search(string word)
        {
            Node node = GetNode(word);
            return GetNode(word) is not null && node.IsCompleteWord;
        }

        public bool StartsWith(string prefix)
        {
            return GetNode(prefix) is not null;
        }

        private Node GetNode(string word)
        {
            Node current = Root;
            char[] characteres = word.ToCharArray();
            foreach (var c in characteres)
            {
                Node child = current.Children.GetValueOrDefault(c);
                if (child is null) return null;
                current = child;
            }
            return current;
        }

        //public int GetWordsCountStartsWithPrefix(string prefix)
        //{

        //}
    }
}
