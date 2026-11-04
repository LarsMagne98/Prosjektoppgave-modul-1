public class LoggingService
{
    LoggingVault vault = new LoggingVault();
    IReadOnlyList<Logging> copy;

    public LoggingService()
    {
        copy = vault.GetLoggings();
    }

    const string events = "events.txt";
    string[] lines = File.ReadAllLines(events);

    public void FileToList()
    {
        foreach (var line in lines)
        {
            Logging? newLogging = LoggingRead.FromFileLine(line);

            if (newLogging != null)
            {
                vault.Add(newLogging);
            }
        }
    }

    public void PrintAllEvents()
    {
        foreach (var item in copy)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }

    public void FindByInfo()
    {
        List<Logging> info = copy.Where(log => log.Level == "INFO").ToList();

        foreach (var item in info)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }
    public void FindByWarning()
    {
        List<Logging> warning = copy.Where(log => log.Level == "WARNING").ToList();

        foreach (var item in warning)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }
    public void FindByError()
    {
        List<Logging> error = copy.Where(log => log.Level == "ERROR").ToList();

        foreach (var item in error)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }
    public void FindByCheckout()
    {
        List<Logging> checkout = copy.Where(log => log.Source == "Checkout").ToList();

        foreach (var item in checkout)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }
    public void FindByPayments()
    {
        List<Logging> payments = copy.Where(log => log.Source == "Payments").ToList();

        foreach (var item in payments)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }
    public void FindByInventory()
    {
        List<Logging> inventory = copy.Where(log => log.Source == "Inventory").ToList();

        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }

    public void SearchInMessage(string? search)
    {
        List<Logging> searcher = copy.Where(log => search is not null && log.Message?.Contains(search) == true).ToList();

        foreach (var item in searcher)
        {
            Console.WriteLine($"{item.Level} | {item.Source} | {item.Message}");
        }
    }

}
