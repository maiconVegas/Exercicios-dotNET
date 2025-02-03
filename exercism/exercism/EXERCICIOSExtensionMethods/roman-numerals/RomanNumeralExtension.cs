using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSExtensionMethods.roman_numerals;
public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        (int, string)[] RomanValue =
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        };
        string result = string.Empty;
        foreach (var (valor, simbolo) in RomanValue)
        {
            while (value >= valor)
            {
                result += simbolo;
                value -= valor;
            }
        }
        return result;
    }
}
