using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Xunit.Sdk;

public class FacialFeatures : IEquatable<FacialFeatures>
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public bool Equals(FacialFeatures other) => this.EyeColor == other.EyeColor && this.PhiltrumWidth == other.PhiltrumWidth;

    public override bool Equals(object obj) => Equals(obj as FacialFeatures);
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}
    public class Identity : IEquatable<Identity>
    {
        public string Email { get; }
        public FacialFeatures FacialFeatures { get; }

        public Identity(string email, FacialFeatures facialFeatures)
        {
            Email = email;
            FacialFeatures = facialFeatures;
        }

        // TODO: implement equality and GetHashCode() methods

        public bool Equals(Identity other) => this.Email.Equals(other.Email) && this.FacialFeatures.Equals(other.FacialFeatures);

        public override bool Equals(object obj) => Equals(obj as Identity);
        public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
    }

    public class Authenticator
    {
        public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => (faceA.Equals(faceB) && faceA.GetHashCode() == faceB.GetHashCode());
        public HashSet<Identity> Registered { get; } = new HashSet<Identity>();
        public bool IsAdmin(Identity identity)
        {
            Identity adminIdentity = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
            return adminIdentity.Equals(identity);
        }

        public bool Register(Identity identity)
        {
            if ((Registered.Contains(identity)))
            {
                return false;
            }
            else
            {
                Registered.Add(identity);
                return true;
            }
        }

        public bool IsRegistered(Identity identity) => Registered.Contains(identity);


    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
    }