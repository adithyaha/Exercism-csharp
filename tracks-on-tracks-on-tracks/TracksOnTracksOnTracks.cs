using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public static class Languages
{   
    public static List<string> NewList()
    {
        var list = new List<string>();
        return list;
    }

    public static List<string> GetExistingLanguages()
    {
        var languagesList = new List<string>();
        languagesList.Add("C#");
        languagesList.Add("Clojure");
        languagesList.Add("Elm");
        return languagesList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        var list = languages;
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        var languagesList = languages;
        return languagesList.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        var LanguagesList = languages;
        return LanguagesList.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        var LanguagesList = languages;
        LanguagesList.Reverse();
        return LanguagesList;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count> 0 && languages[0] == "C#") {  return true; }
        if (languages.Count >= 2 && languages[1] == "C#")
        {
            return languages.Count == 2 || languages.Count == 3;
        }
        
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        var languagesList = languages;
        languagesList.Remove(language);
        return languagesList;
    }

    public static bool IsUnique(List<string> languages) 
    {
        HashSet<string> unique = new HashSet<string>();
        foreach(string language in languages)
        {
            unique.Add(language);
        }
        return (unique.Count == languages.Count);
    }
}
