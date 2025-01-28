using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.isogram
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            //string worked = new string(word.ToUpper().Where(char.IsLetter).ToArray());
            //for (int i = 0; i < word.Where(char.IsLetter).Count(); i++)
            //{
            //    for (int j = i+1; j < word.Where(char.IsLetter).Count(); j++)
            //    {
            //        if (worked[i].Equals(worked[j]))
            //        {
            //            return false;
            //        }
            //    }
            //}
            //return true;

            var wordUpper = word.ToUpper().Where(char.IsLetter);
            return wordUpper.Distinct().Count() == wordUpper.Count();
        }
    }
}
