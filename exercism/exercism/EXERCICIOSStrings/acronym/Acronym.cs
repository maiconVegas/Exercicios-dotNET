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
            string Abreviated = string.Empty;
            var pontuacoes = new string(phrase.Where(char.IsPunctuation).ToArray());
            var resultado = phrase.Replace(pontuacoes, " ").Split();
            for (int i = 0; i < resultado.Length; i++)
            {
                Abreviated += resultado[i].ToString()[0];
            }
            return Abreviated.ToUpper();
        }
    }
}
