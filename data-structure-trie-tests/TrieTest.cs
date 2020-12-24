using data_structure_trie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace data_structure_trie_tests
{
    [TestClass]
    public class TrieTest
    {
        private readonly string[] _words = { "mouse", "screen", "board", "hat", "car", "card" };

        [TestMethod]
        public void InsertWords()
        {
            Trie trie = new Trie();
            bool allWordsInserted = true;
            _words.ToList().ForEach(word => trie.Insert(word));
            _words.ToList().ForEach(word =>
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
            _words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.Search("mouse");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchForWordThatNotExists()
        {
            Trie trie = new Trie();
            _words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.Search("book");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SearchForPrefixThatExists()
        {
            Trie trie = new Trie();
            _words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.StartsWith("mo");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchForPrefixThatNotExists()
        {
            Trie trie = new Trie();
            _words.ToList().ForEach(word => trie.Insert(word));
            bool result = trie.Search("tra");
            Assert.IsFalse(result);
        }
    }
}
