using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOTuples.word_search
{
    public class WordSearch
    {
        private readonly string[] grid;
        public WordSearch(string grid) => this.grid = grid.Split("\n");

        public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
