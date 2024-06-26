using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;

public class LogParser
{
    public bool IsValidLine(string text)
    {
        string pattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\].*$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(text);
    }

    public string[] SplitLogLine(string text)
    {
        string pattern = @"<[*-=^]+>";
        Regex regex = new Regex(pattern);
        var matches = new List<string>();
        return regex.Split(text);
    }

    public int CountQuotedPasswords(string lines)
    {
        string splitIntoLinesPattern = @"\r?\n";
        int count = 0;
        Regex regex = new Regex(splitIntoLinesPattern);
        string[] Lines = regex.Split(lines);
        foreach (string line in Lines)
        {
            string passwordPattern = @"""[^""]*password[^""]*""";
            Regex reg = new Regex(passwordPattern, RegexOptions.IgnoreCase);
            if (reg.IsMatch(line)) {
                count++;
            }
        }
        return count;

        
    }

    public string RemoveEndOfLineText(string line)
    {
        string endOfLinePattern = @"end-of-line[0-9]*"; // Pattern to match "end-of-line" followed by optional digits
        Regex regex = new Regex(endOfLinePattern);
        return regex.Replace(line, "");
    }
    private readonly string weakPasswordRegexPattern = @"password\w+";
    public string[] ListLinesWithPasswords(string[] lines)
    {

        var processedLines = new List<string>();
        foreach (string line in lines)
        {
            Match passwordMatch = Regex.Match(line, weakPasswordRegexPattern, RegexOptions.IgnoreCase);
            if (passwordMatch == Match.Empty)
                processedLines.Add($"--------: {line}");
            else
                processedLines.Add($"{passwordMatch.Value}: {line}");
        }
        return processedLines.ToArray();
    }
}
