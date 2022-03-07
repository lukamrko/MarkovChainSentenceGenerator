using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MarkovChainSentenceGenerator.Generator
{
    internal class TextGenerator
    {
        BigramGenerator bigramGenerator;

        public TextGenerator()
        {
            this.bigramGenerator = new BigramGenerator();
        }

        public string ConanText(int limit)
        {
            Dictionary<string, Dictionary<string, int>> bigrams = this.bigramGenerator.ConanBigrams();
            bigrams.Remove("");
            List<string> textList = GenereteTextArray(bigrams, limit);
            string connectedTextList = string.Join(" ", textList);
            return connectedTextList;
        }

        private List<string> GenereteTextArray(Dictionary<string, Dictionary<string, int>> bigrams, int limit)
        {
            List<string> textList = new List<string>();
            bool lastWordSentenceEnder = true;
            string word="";
            for (int i = 0; i < limit; i++)
            {
                if (lastWordSentenceEnder)
                {
                    word = GetRandomFirstWord(bigrams);
                    if (IsSentenceEnder(word, bigrams))
                        lastWordSentenceEnder = true;
                    else
                        lastWordSentenceEnder = false;
                }
                else
                {
                    word = GenerateNextWord(bigrams[word]);
                    if (IsSentenceEnder(word, bigrams))
                        lastWordSentenceEnder = true;
                    else
                        lastWordSentenceEnder = false;
                }
                textList.Add(word);
            }
            return textList;
        }

        private string GenerateNextWord(Dictionary<string, int> dictionary)
        {
            int numberOfOccurences = 0;
            foreach (int occurence in dictionary.Values)
            {
                numberOfOccurences += occurence;
            }
            int random = RandomNumberGenerator.GetInt32(numberOfOccurences);
            int counter = 0;
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                counter += kvp.Value;
                if (counter >= random)
                {
                    dictionary[kvp.Key]--;
                    if(dictionary[kvp.Key] == 0)
                        dictionary.Remove(kvp.Key);
                    return kvp.Key;
                }
            }
            return " ";
        }

        private bool IsSentenceEnder(string word, Dictionary<string, Dictionary<string, int>> bigrams)
        {
            if (bigrams.ContainsKey(word))
                return false;
            return true;
        }

        private string GetRandomFirstWord(Dictionary<string, Dictionary<string, int>> bigrams)
        {
            List<string> words = bigrams.Keys.Where(x => char.IsUpper(x[0])).ToList();
            int random = RandomNumberGenerator.GetInt32(words.Count);
            return words[random];
        }
    }
}
