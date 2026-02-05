using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        StringBuilder sb = new StringBuilder();
        if(id != null)
        {
            sb.Append($"[{id}]");
            sb.Append(" - ");
        }

        sb.Append(name);
        sb.Append(" - ");
        sb.Append(department?.ToUpper() ?? "OWNER");

        return sb.ToString();

    }
}
