using System.Text;

static class LogLine
{
    public static string Message(string logLine)
    {
        int posicion = logLine.IndexOf(":");
        string msg2 = logLine.Substring(posicion+1);
        string msg3 = msg2.Trim();

        return $"{msg3}";
    }

    public static string LogLevel(string strilogLine)
    {
        int posicion1 = strilogLine.IndexOf("]");
        string msg1 = strilogLine.Substring(1,posicion1-1);

        return msg1.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLvl = LogLevel(logLine);
        string msg = Message(logLine);

        return $"{msg} ({logLvl.ToLower()})";
    }
}