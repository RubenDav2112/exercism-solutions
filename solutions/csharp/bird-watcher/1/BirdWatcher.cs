class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int [] birdsLW = {0, 2, 5, 3, 7, 8, 4};
        return birdsLW;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        if(birdsPerDay.Contains(0))
        {
            return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sumaP = 0;
        for(int i=0 ; i<numberOfDays ; i++)
        {
            sumaP = sumaP + birdsPerDay[i];
        }
        return sumaP;
    }

    public int BusyDays()
    {
        int c = 0;
        foreach (var bird in birdsPerDay)
        {
            if(bird >= 5)
            {
                c++;
            }
        }
        return c;
    }
}
