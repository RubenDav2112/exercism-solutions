using System.Text;
using System;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        char c = ' ';
        bool proximaMayus = false;

        for (int i = 0; i < identifier.Length; i++)
        {
            c = identifier[i];

            if(c == ' ')
            {
                sb.Append('_');
            }else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }else if (c == '-')
            {
                proximaMayus = true;
            }else if (char.IsLetter(c))
            {
                if(c >= 'α' && c <= 'ω')
                {
                    continue;
                }

                if (proximaMayus)
                {
                    sb.Append(char.ToUpper(c));
                    proximaMayus = false;
                }
                else
                {
                    sb.Append(c);
                } 
            }
        }
        return sb.ToString();
    }
}
