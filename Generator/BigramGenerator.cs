using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovChainSentenceGenerator.Generator
{
    internal class BigramGenerator
    {
        public Dictionary<string, Dictionary<string, int>> ConanBigrams()
        {
            Dictionary<string, Dictionary<string, int>> conanBigrams = new Dictionary<string, Dictionary<string, int>>();
            string nextWord = "";
            foreach (string putanja in Directory.EnumerateFiles(Environment.CurrentDirectory + "\\conan\\", "*.txt"))
            {
                string[] lines = File.ReadAllLines(putanja);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] words = lines[i].Split(' ');
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (IsEndOfSentence(words[j]))
                            continue;
                        if (j == words.Length - 1)
                            nextWord = lines[i + 1].Split(' ')[0];
                        else
                            nextWord = words[j + 1];
                        if (conanBigrams.ContainsKey(words[j]))
                        {
                            if (conanBigrams[words[j]].ContainsKey(nextWord))
                                conanBigrams[words[j]][nextWord]++;
                            else
                                conanBigrams[words[j]].Add(nextWord, 1);
                        }
                        else
                            conanBigrams.Add(words[j], new Dictionary<string, int>() { { nextWord, 1 } });
                    }
                }
            }
            return conanBigrams;
        }

        private bool IsEndOfSentence(string word)
        {
            string[] endSymbols = new string[] 
            {
                "!",
                "?",
                "."
                //".'"
            };
            for (int i = 0; i < endSymbols.Length; i++)
            {
                if(word.Contains(endSymbols[i]))
                    return true;
            }
            return false;
        }
    }
}
