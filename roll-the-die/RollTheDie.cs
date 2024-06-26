using System;

public class Player
{

    public int RollDie()
    {
        Random dieRoll = new Random();
        int roll = dieRoll.Next(1, 18);
        return roll;

    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        double spellStrength = random.NextDouble() * 100;
        return spellStrength;
    }
}
