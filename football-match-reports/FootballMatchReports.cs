using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1: return "goalie";
            case 2: return "left back";
            case 3:
            case 4: return "center back";
            case 5: return "right back";
            case 6:
            case 7:
            case 8: return "midfielder";
            case 9: return "left wing";
            case 10: return "striker";
            case 11: return "right wing";
            default: throw new ArgumentOutOfRangeException(nameof(shirtNum), "Invalid shirt number");
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int numberOfSupporters:
                return $"There are {numberOfSupporters} supporters at the match.";
            case string announcements:
                return announcements;
            case Foul foulReport:
                return foulReport?.GetDescription() ?? "No description available.";
            case Manager managerReport:
                return managerReport.Club == null ? managerReport.Name : $"{managerReport.Name} ({managerReport.Club})";
            case Injury injuryReport:
                return $"Oh no! {injuryReport.GetDescription()} Medics are on the field.";
            case Incident incidentReport:
                return "An incident happened.";
            default:
                throw new ArgumentException("Invalid report type", nameof(report));
        }
    }
}

