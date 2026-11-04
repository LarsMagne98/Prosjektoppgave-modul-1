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

        if ((parts[0] is "INFO" or "WARNING" or "ERROR") &&
            (parts[1] is "Checkout" or "Payments" or "Inventory"))
        {
            return new Logging(parts[0], parts[1], parts[2]);
        }

        return null;

    }
}