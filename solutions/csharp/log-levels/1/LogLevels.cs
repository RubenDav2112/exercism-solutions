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
        int posicion = logLine.IndexOf("]");
        string msg = logLine.Substring(1,posicion-1);

        int posicion2 = logLine.IndexOf(":");
        string msg2 = logLine.Substring(posicion2+1);
        string msg3 = msg2.Trim();

        return $"{msg3} ({msg.ToLower()})";
    }
}