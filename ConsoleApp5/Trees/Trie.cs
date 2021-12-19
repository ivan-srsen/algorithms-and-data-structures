namespace ConsoleApp5.Trees
{
    internal class Trie
    {
        private TrieNode root = new TrieNode();

        public void Insert(string word)
        {
            var current = root;

            for(var i = 0; i < word.Length; i++)
            {
                var currentLetter = word[i];
                var letterIndex = currentLetter - 97;
                var currentLetterNode = current.Letters[letterIndex];

                var isLast = i == word.Length - 1;

                if(currentLetterNode == null)
                {
                    current.Letters[letterIndex] = new TrieNode(currentLetter, isLast);
                    continue;
                }

                current = current.Letters[letterIndex];
            }
        }

        public bool Search(string word)
        {
            var current = root;

            for(var i = 0; i < word.Length; i++)
            {
                var currentLetter = word[i];
                var letterIndex = currentLetter - 97;
                var currentLetterNode = current.Letters[letterIndex];

                var isLast = i == word.Length - 1;

                if (currentLetterNode == null)
                    return false;

                if(isLast && currentLetterNode.IsLast)
                    return true;

                current = currentLetterNode;
            }

            return false;
        }

        public class TrieNode
        {
            public TrieNode[] Letters = new TrieNode[26];
            public char Character;
            public bool IsLast;

            public TrieNode() { }
            public TrieNode(char character, bool isLast)
            {
                this.character = character;
                this.isLast = isLast;
            }
        }
    }
}
