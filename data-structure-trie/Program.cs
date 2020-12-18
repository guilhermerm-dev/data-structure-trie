using System;

namespace data_structure_trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("computer");
            trie.Insert("mouse");
            trie.Insert("board");

            string nameToSearch = "computer";
            if (trie.Search(nameToSearch))
            {
                Console.WriteLine($"Found {nameToSearch}");
            }
            else
            {
                Console.WriteLine($"Not found {nameToSearch}");
            }

            nameToSearch = "screen";
            if (trie.Search(nameToSearch))
            {
                Console.WriteLine($"Found {nameToSearch}");
            }
            else
            {
                Console.WriteLine($"Not found {nameToSearch}");
            }

            string prefixToSearch = "mo";
            if (trie.StartsWith(prefixToSearch))
            {
                Console.WriteLine($"Found word with prefix {prefixToSearch}");
            }
            else
            {
                Console.WriteLine($"Not Found word with prefix {prefixToSearch}");
            }

            Console.ReadKey();
        }
    }
}
