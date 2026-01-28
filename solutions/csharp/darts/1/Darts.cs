public static class Darts
{
    public static int Score(double x, double y)
    {
        double distancia = Math.Sqrt(x*x + y*y);

        if(distancia > 10)
        {
            return 0;
        }else if(distancia > 5)
        {
            return 1;
        }else if(distancia > 1)
        {
            return 5;
        }
        else
        {
            return 10;
        }
    }
}
