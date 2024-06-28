using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        string message = logLine.Split(':')[1];
        message = message.Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        string logLevel = logLine.Split(':')[0];
        logLevel = logLevel.ToLower().Trim();
        logLevel = logLevel.Substring(1, logLevel.Length - 2);
        return logLevel;
    }

    public static string Reformat(string logLine)
    {
        string[] logs = logLine.Split(":");
        string warning =logs[0].Replace('[', '(').Trim();
        warning = warning.Replace(']', ')');
        warning = warning.ToLower();
        string message = logs[1].Substring(1, logs[1].Length - 1);
        message = Regex.Replace(message, @"\t|\n|\r", "").Trim();



        string newLog = message + " " + warning;
        return newLog;
    }
}
