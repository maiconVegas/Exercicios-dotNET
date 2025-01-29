using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.anagram
{
    public class Anagram
    {
        private readonly string FindAnagram;
        public Anagram(string baseWord) => FindAnagram = baseWord.ToLower();

        public string[] FindAnagrams(string[] potentialMatches)
        {
            var resultados = new List<string>();
            foreach (var provavel in potentialMatches)
            {
                if (!provavel.ToLower().Equals(FindAnagram) && IsAnagram(provavel, FindAnagram))
                {
                    resultados.Add(provavel);
                }
            }
            return resultados.ToArray();
        }

        private bool IsAnagram(string provavel, string match)
        {
            provavel = string.Concat(provavel.ToLower().OrderBy(x => x));
            match = string.Concat(match.ToLower().OrderBy(x => x));
            return provavel == match;
        }
    }
}
