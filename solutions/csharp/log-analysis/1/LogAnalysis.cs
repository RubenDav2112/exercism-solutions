public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type


    public static string SubstringAfter(this string str, string delimiter)
    {
        int pos = str.IndexOf(delimiter);
        return str.Substring(pos + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string del1, string del2)
    {
        int pos = str.IndexOf(del1) + del1.Length;
        int pos2 = str.IndexOf(del2);

        return str.Substring(pos , pos2 - pos);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return SubstringAfter(str,": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return SubstringBetween(str,"[","]");
    }
}