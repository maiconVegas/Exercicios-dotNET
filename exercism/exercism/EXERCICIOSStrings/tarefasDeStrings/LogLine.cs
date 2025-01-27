using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.EXERCICIOSStrings.tarefasDeStrings
{
    public class LogLine
    {
        public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(":") + 1).Trim();
        //{            
        //    //int a = logLine.IndexOf(":") + 1;
        //    //string corrigido = logLine.Substring(a).Trim();
        //    //return corrigido;

        //    return logLine.Substring(logLine.IndexOf(":") + 1).Trim();
        //}

        public static string LogLevel(string logLine)
        {
            int inicio = logLine.IndexOf('[') + 1;
            int fim = logLine.IndexOf(']') - 1;
            return logLine.Substring(inicio, fim).ToLower();
        }

        public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
        //{
        //    return $"{Message(logLine)} ({LogLevel(logLine)})";
        //}
    }
}
