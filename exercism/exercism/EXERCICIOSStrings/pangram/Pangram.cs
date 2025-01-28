using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.pangram
{
    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultado = new string(
                input.ToUpper()
                .Where(char.IsLetter)
                .OrderBy(x=>x)
                .Distinct().ToArray());
            return resultado.Contains(alfabeto);

            // tem o metodo .OrderBy(x=>x) -----> que ordena em ordem crescente com em comparação dos mesmos valores (entao esta comparando o valor com valor a si mesmo)
            // tem o metodo .OrderByDescending(x=>x) -----> que ordena em ordem decrescente com em comparação dos mesmos valores (entao esta comparando o valor com valor a si mesmo)

        }
    }
}
