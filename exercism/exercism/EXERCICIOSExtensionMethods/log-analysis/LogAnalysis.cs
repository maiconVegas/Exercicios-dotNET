using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSExtensionMethods.log_analysis
{
    public static class LogAnalysis
    {
        public static string SubstringAfter(this string str, string delimiter) => str.Substring(str.IndexOf(delimiter) + delimiter.Length);

        public static string SubstringBetween(this string str, string left, string right) =>
            str.Substring(str.IndexOf(left) + left.Length, str.IndexOf(right) - (str.IndexOf(left) + left.Length));

        public static string Message(this string str) => str.SubstringAfter(": ");

        public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
    }
}
