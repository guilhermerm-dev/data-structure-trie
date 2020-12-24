using System;
using System.Linq;

namespace data_structure_trie
{
    class Program
    {
        static void Main()
        {
            string[] words = { "computer", "mouse", "board" };
            Trie trie = new Trie();
            words.ToList().ForEach(word => trie.Insert(word));

            if (trie.Search("computer"))
                Console.WriteLine("Word found!");

            if (trie.Search("horse"))
                Console.WriteLine("Word found!");

            if (trie.StartsWith("yo"))
                Console.WriteLine("Prefix found!");
        }
    }
}
