using data_structure_trie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace data_structure_trie_tests
{
    [TestClass]
    public class TrieTest
    {

        [TestMethod]
        public void InsertWords()
        {
            Trie trie = new Trie();
            bool allWordsInserted = true;
            string[] words = { "mouse", "screen", "board", "hat", "car", "card" };
            words.ToList().ForEach(word => trie.Insert(word));
            words.ToList().ForEach(word =>
            {
                if (!trie.Search(word))
                    allWordsInserted = false;
            });
            Assert.IsTrue(allWordsInserted);
        }

        [TestMethod]
        public void SearchForWordThatExists()
        {
            Trie trie = new Trie();
            string[] words = { "mouse", "screen", "board", "hat", "car", "card" };
            words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.Search("mouse");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchForWordThatNotExists()
        {
            Trie trie = new Trie();
            string[] words = { "mouse", "screen", "board", "hat", "car", "card" };
            words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.Search("book");
            Assert.IsFalse(result);
        }
    }
}
