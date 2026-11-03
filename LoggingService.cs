public class LoggingService
{
    LoggingVault vault = new LoggingVault();
    IReadOnlyList<Logging> loggings;
    const string events = "events.txt";

    public LoggingService()
    {
        loggings = vault.GetLoggings();
    }
    string[] lines = File.ReadAllLines(events);


    public void test()
    {
        foreach (var line in lines)
        {
            Logging? newLogging = LoggingRead.FromFileLine(line);

            if (newLogging != null)
            {
                vault.Add(newLogging);
            }
        }

        foreach (var item in loggings)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }

}
