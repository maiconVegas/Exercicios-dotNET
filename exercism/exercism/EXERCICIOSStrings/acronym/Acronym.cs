using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.acronym
{
    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            var resultado = phrase.Split(new char[] {' ', '-', '_'}, StringSplitOptions.RemoveEmptyEntries);
            string Abreviated = string.Empty;
            foreach (var word in resultado)
            {
                Abreviated += word[0];
            }
            return Abreviated.ToUpper();
        }

        /*
         foi usado esse tipo de parametro do Split()
        public string[] Split(char[]? separator, StringSplitOptions options)
        {
            return SplitInternal(separator, int.MaxValue, options);
        }
         */
    }
}
