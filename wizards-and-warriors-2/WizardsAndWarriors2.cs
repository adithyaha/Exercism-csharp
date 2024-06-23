using System;

static class GameMaster
{
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    }

    public static string Describe(Destination destination)
    {   
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public static string Describe(TravelMethod travelMethod) =>
    
        travelMethod switch{
            TravelMethod.Horseback => $"You're traveling to your destination on horseback.",
            TravelMethod.Walking => $"You're traveling to your destination by walking.",
            _ => throw new ArgumentException("Invalid argument for TravelMethod enum.")
        };
    
    

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        string characterDescription =  $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
        string destinationDescription = $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
        string travelMethodDescription = travelMethod switch{
            TravelMethod.Horseback => $"You're traveling to your destination on horseback.",
            TravelMethod.Walking => $"You're traveling to your destination by walking.",
            _ => throw new ArgumentException("Invalid argument for TravelMethod enum.")
        };

        return $"{characterDescription} {travelMethodDescription} {destinationDescription}";
    }

    public static string Describe(Character character, Destination destination)
    {
        string characterDescription =  $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
        string destinationDescription = $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
         
        return $"{characterDescription} You're traveling to your destination by walking. {destinationDescription}";

    }
}

class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}
