using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercism.squeaky_clean
{
    internal static class Identifier
    {
        public static string Clean(string identifier)
        {
            var builder = new StringBuilder();
            char passado = ' ';
            foreach (var item in identifier)
            {
                // task 1
                if (char.IsWhiteSpace(item) || char.IsSeparator(item))
                {
                    builder.Append('_');
                }
                // task 2
                else if (char.IsControl(item))
                {
                    builder.Append("CTRL");
                }
                //task 3
                else if (passado.Equals('-'))
                {
                    builder.Append(char.ToUpper(identifier[identifier.IndexOf(item)]));
                }
                //task 4
                else if (char.IsLetter(item))
                {
                    // task 5
                    if (item < 'α' || item > 'ω')
                    {
                        builder.Append(item);
                    }
                    //builder.Append(item);
                }
                
                passado = item;
            }

            return builder.ToString();
        }



        // MENSAGEM PARA MIM MESMO
        // QUANDO VOLTAR, MELHORE O CODIGO, TEM MUITA COISA QUE PODE SER SIMPLIFICADO E 
        // REDUZIDO ESSAS CONDIÇÕES E CODIGOS



        /*
         
        public static string Clean(string identifier)
        {
            // task 1
            identifier = identifier.Replace(" ", "_");

            // task 2, 3
            int index = 0;
            foreach (var item in identifier)
            {
                // task 2
                if (char.IsControl(item))
                {
                    index = identifier.IndexOf(item);
                    identifier = identifier.Remove(index, 1);
                    identifier = identifier.Insert(index, "CTRL");
                }
                //task 3
                if (item.Equals('-'))
                {
                    index = identifier.IndexOf(item);
                    identifier = identifier.Remove(index, 1);
                    identifier = identifier.Replace(identifier[index], char.ToUpper(identifier[index]));
                }
                if (!char.IsLetter(item))
                {
                    index = identifier.IndexOf(item);
                    identifier = identifier.Remove(identifier.IndexOf(item));
                }
            }

            return identifier;

        }
         
         */
    }
}
