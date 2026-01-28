using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int reales)
    {
        return (40 - reales);
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int capas)
    {
        return(capas*2);
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int capas, int tiempoHorno)
    {
        int total = (capas*2) + tiempoHorno;
        return total; 
    }
}
