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
        if(string.IsNullOrEmpty(input)) return input;
        StringBuilder output = new StringBuilder();
        string count = string.Empty;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                count += c;
            }
            else if(!string.IsNullOrEmpty(count))
            {
                for (int i = 0; i < Convert.ToInt32(count); i++)
                {
                    output.Append(c);
                }
                count = "";
            }
            else
            {
                output.Append(c);
            }
        }

        return output.ToString();
    }
}
