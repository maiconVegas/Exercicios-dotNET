using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.tracks_on_tracks_on_tracks;
public static class Languages
{
    private static List<string> listLearn = new List<string>() { "C#", "Clojure", "Elm" };

    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages() => listLearn;

    public static List<string> AddLanguage(List<string> languages, string language) => languages.Append(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages) => languages.AsEnumerable().Reverse().ToList();

    public static bool IsExciting(List<string> languages) => (languages.Count > 0 && languages[0].Equals("C#")) || (languages.Count > 1 && (languages[1].Equals("C#") && (languages.Count == 2 || languages.Count == 3)));

    public static List<string> RemoveLanguage(List<string> languages, string language) => languages.Where(l => l != language).ToList();    

    public static bool IsUnique(List<string> languages) => languages.Distinct().Count() == languages.Count;
}
