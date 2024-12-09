using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.squeaky_clean
{
    internal static class Identifier
    {
        public static string Clean(string identifier)
        {
            identifier = identifier.Replace(" ", "_");
            var result = new StringBuilder();
            foreach (char c in identifier) 
            {
                if (char.IsControl(c))
                {
                    result.Append(c);
                }
            }
            return identifier;

        }
    }
}
