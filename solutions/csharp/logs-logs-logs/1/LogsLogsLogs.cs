// TODO: define the 'LogLevel' enum

enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0,
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        int pos = logLine.IndexOf(']');
        int pos2 = logLine.IndexOf('[');
        string substring = logLine.Substring(pos2 + 1, pos - (pos2 + 1));


        return substring switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };

    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {

        return $"{(int)logLevel}:{message.Trim()}";
    }
}
