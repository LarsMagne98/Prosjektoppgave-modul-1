public class LoggingService
{

    List<Logging> loggings = new List<Logging> { };
    const string events = "events.txt";

    string[] lines = File.ReadAllLines(events);

    public void test()
    {
        foreach (var line in lines)
        {
            Logging? newLogging = LoggingRead.FromFileLine(line);

            if (newLogging != null)
            {
                loggings.Add(newLogging);
            }
        }

        foreach (var item in loggings)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }

}
