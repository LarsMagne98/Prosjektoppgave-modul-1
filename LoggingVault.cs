public class LoggingVault
{
    private List<Logging> loggings = new List<Logging> { };

    public IReadOnlyList<Logging> GetLoggings()
    {
        return loggings.AsReadOnly();
    }

    public void Add(Logging logging)
    {
        loggings.Add(logging);
    }

}