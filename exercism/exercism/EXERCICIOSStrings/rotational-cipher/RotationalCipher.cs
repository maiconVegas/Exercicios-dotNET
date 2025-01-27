using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercism.wizards_and_warriors;

namespace exercism.EXERCICIOSStrings.rotational_cipher;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string result = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char index = char.IsUpper(c) ? 'A' : 'a';
                char rotated = Convert.ToChar(Convert.ToInt32(index) + ((Convert.ToInt32(c) - Convert.ToInt32(index) + shiftKey) % 26));
                result += rotated;
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
}
