using System.Linq;

public class HighScores
{
    private List<int> _list = new List<int>();
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores()
    {
        return _list;
    }

    public int Latest()
    {
        return _list.Last();
    }

    public int PersonalBest()
    {
        return _list.Max();
    }

    public List<int> PersonalTopThree()
    {
        return _list.OrderByDescending(score => score).Take(3).ToList();
    }
}