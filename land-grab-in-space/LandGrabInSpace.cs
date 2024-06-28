using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Coord other)
    {
        return this.X == other.X && this.Y == other.Y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    Coord a;
    Coord b;
    Coord c;
    Coord d;

    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }


    public bool Equals(Plot other)
    {
        return this.a.Equals(other.a) && this.b.Equals(other.b) && this.c.Equals(other.c) && this.d.Equals(other.d);
    }

    public double[] sides = new double[4];

    public double[] getSides()
    {
        double ab = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        sides[0] = ab;
        double bc = Math.Sqrt(Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2));
        sides[1] = bc;
        double cd = Math.Sqrt(Math.Pow(c.X - d.X, 2) + Math.Pow(c.Y - d.Y, 2));
        sides[2] = cd;
        double ad = Math.Sqrt(Math.Pow(d.X - a.X, 2) + Math.Pow(d.Y - a.Y, 2));
        sides[3] = ad;

        return sides;
    }

}


public class ClaimsHandler
{
    public List<Plot> stakedClaims = new List<Plot>();
    public void StakeClaim(Plot plot)
    {
        if (IsClaimStaked(plot))
        {
            throw new Exception("claim already staked.");
        }
        else
        {
            stakedClaims.Add(plot);
        }

    }

    public bool IsClaimStaked(Plot plot)
    {
        return stakedClaims.Any(c => c.Equals(plot));
    }

    public bool IsLastClaim(Plot plot)
    {
        return stakedClaims.Any() && stakedClaims.Last().Equals(plot);
       
    }

    public Plot GetClaimWithLongestSide()
    {
        double longest = 0;
        Plot plotWithLongestSide = default;
        foreach (Plot plot in stakedClaims)
        {
            var sides = plot.getSides();
            foreach (double side in sides)
            {
                if (side > longest)
                {
                    longest = side;
                    plotWithLongestSide = plot;
                }
            }
        }
        return plotWithLongestSide;

    }
}
