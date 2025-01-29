using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.run_length_encoding;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        StringBuilder output = new StringBuilder();
        int count = 1;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                output.Append($"{(count > 1 ? count : "")}{input[i-1]}");
                count = 1;
            }
        }
        output.Append($"{(count > 1 ? count : "")}{input[^1]}");
        return output.ToString();
    }

    public static string Decode(string input)
    {
        throw new NotImplementedException("You need to implement this method.");
    }
}
