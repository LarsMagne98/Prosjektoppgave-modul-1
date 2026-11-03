public class LoggingRead
{
    public static Logging? FromFileLine(string fileLine)
    {
        if (string.IsNullOrWhiteSpace(fileLine))
        {
            return null;
        }

        string[] parts = fileLine.Split('|');

        if (parts.Length != 3)
        {
            return null;
        }

        return new Logging(parts[0], parts[1], parts[2]);

    }
}