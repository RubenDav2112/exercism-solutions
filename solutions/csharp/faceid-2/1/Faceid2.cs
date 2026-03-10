public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;

    }

    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(!(obj is FacialFeatures)) return false;

        var real = (FacialFeatures) obj;

        return EyeColor == real.EyeColor && PhiltrumWidth == real.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor,PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(obj is not Identity) return false;

        var real = (Identity)obj;
        return Email == real.Email && FacialFeatures.Equals(real.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email,FacialFeatures);
    }
}

public class Authenticator
{
    HashSet<Identity> _identities = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity(
            "admin@exerc.ism",
            new FacialFeatures("green",0.9m)
        );

        return identity.Equals(admin);
    }

    public bool Register(Identity identity)
    {
        if(IsRegistered(identity)) return false;

        _identities.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        return _identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA == identityB;
    }
}
