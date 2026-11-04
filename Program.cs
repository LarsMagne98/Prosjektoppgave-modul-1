

LoggingService loggingService = new LoggingService();

loggingService.FileToList();

void MainChoice()
{
    Console.WriteLine("1. Show the entire eventlog.");
    Console.WriteLine("2. Find by level (INFO, WARNING, ERROR).");
    Console.WriteLine("3. Find by source (Checkout, Payments, Inventory).");
    Console.WriteLine("4. Search in message.");
    Console.WriteLine("5. QUIT.");
}

void InLevelChoice()
{
    Console.WriteLine("1. Show INFO events.");
    Console.WriteLine("2. Show WARNING events.");
    Console.WriteLine("3. Show ERROR events.");
    Console.WriteLine("4. BACK.");
}

void InSourceCoice()
{
    Console.WriteLine("1. Show Checkout events.");
    Console.WriteLine("2. Show Payments events.");
    Console.WriteLine("3. Show Inventory events.");
    Console.WriteLine("4. BACK.");
}

bool start = true;

while (start)
{
    MainChoice();
    Console.Write("Your choice: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            loggingService.PrintAllEvents();
            break;
        case "2":
            InLevelChoice();
            Console.Write("Your Choice: ");
            string? levelChoice = Console.ReadLine();

            switch (levelChoice)
            {
                case "1":
                    loggingService.FindByInfo();
                    break;
                case "2":
                    loggingService.FindByWarning();
                    break;
                case "3":
                    loggingService.FindByError();
                    break;
                case "4":

                    break;
            }

            break;
        case "3":
            InSourceCoice();
            Console.Write("Your choice: ");
            string? sourceChoice = Console.ReadLine();

            switch (sourceChoice)
            {
                case "1":
                    loggingService.FindByCheckout();
                    break;
                case "2":
                    loggingService.FindByPayments();
                    break;
                case "3":
                    loggingService.FindByInventory();
                    break;
                case "4":

                    break;
            }
            break;

        case "4":
            Console.Write("Search in message: ");
            string? search = Console.ReadLine();
            loggingService.SearchInMessage(search);
            break;

        case "5":
            start = false;
            break;
    }

}