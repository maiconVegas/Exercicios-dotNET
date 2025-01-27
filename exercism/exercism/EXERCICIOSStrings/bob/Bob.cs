using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.bob;
public static class Bob
{
    public static string Response(string statement) =>
        StatementIsUpperWithQuestion(statement) ? "Calm down, I know what I'm doing!" :
        StatementIsUpper(statement) ? "Whoa, chill out!" :
        QuestionEnd(statement) ? "Sure." : "Amem";

    private static bool StatementIsUpper(string statement)
    {
        foreach (char c in statement)
        {
            if (char.IsLetter(c))
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }
        }
        return true;
    }

    private static bool StatementIsUpperWithQuestion(string statement)
    {
        foreach (char c in statement)
        {
            if (char.IsLetter(c))
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }
        }
        return QuestionEnd(statement);
    }

    private static bool QuestionEnd(string statement) => statement[statement.Length - 1] == '?';
}
