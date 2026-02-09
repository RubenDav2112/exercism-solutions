public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        return shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "centre back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
        };
    }

    public static string AnalyzeOffField(object report)
    {
        return report switch
        {
            int number => $"There are {number} supporters at the match.",
            string text => text,
            Injury inj => $"Oh no! {inj.GetDescription()} Medics are on the field.",
            Incident inc => inc.GetDescription(),
            Manager man when man.Name != null && man.Club != null  => $"{man.Name} ({man.Club})",
            Manager man when man.Club == null => man.Name,
            Manager _ => "Unknown",
            _ => "",

        };
    }
}
