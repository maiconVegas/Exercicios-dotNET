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
        QuestionEnd(statement) ? "Sure." :
        Silence(statement)? "Fine. Be that way!" : "Whatever.";

    private static bool StatementIsUpper(string statement) =>
        statement.Where(char.IsLetter).All(char.IsUpper) && ContainsWord(statement);

    private static bool StatementIsUpperWithQuestion(string statement) =>
        ContainsWord(statement) && QuestionEnd(statement) && StatementIsUpper(statement);

    private static bool QuestionEnd(string statement) => statement.Trim().EndsWith('?');

    private static bool ContainsWord(string statement) => statement.Any(char.IsLetter);

    private static bool Silence(string statement) => string.IsNullOrWhiteSpace(statement);
}
