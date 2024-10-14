bool exitApp = false;

while (!exitApp)
{
    // Display Greenville motto and menu
    Console.Clear();
    DisplayMotto();
    DisplayMenu();

    // Read user's menu choice
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Call method to calculate and display revenue
            CalculateAndDisplayRevenue();
            break;
        case "2":
            // Exit the app
            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
            exitApp = true;
            break;
        default:
            // Handle invalid input
            Console.WriteLine("Invalid input, please try again.");
            break;
    }

    if (!exitApp)
    {
        // Pause before showing the menu again
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}

static void DisplayMotto()
{
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************\n");
}

static void DisplayMenu()
{
    Console.WriteLine("Please Enter the following number below from the following menu:\n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit\n");
}

static void CalculateAndDisplayRevenue()
{
    int lastYearContestants = GetValidContestantCount("Enter the number of contestants from last year (0-30): ");
    int thisYearContestants = GetValidContestantCount("Enter the number of contestants for this year (0-30): ");
    int ticketPrice = 25;

    // Calculate revenue
    int revenueThisYear = thisYearContestants * ticketPrice;

    // Determine if this year's competition is bigger
    bool isBigger = thisYearContestants > lastYearContestants;

    // Display the results
    if (thisYearContestants >= 2 * lastYearContestants)
    {
        Console.WriteLine("The competition is more than twice as big this year!");
    }
    else if (thisYearContestants > lastYearContestants)
    {
        Console.WriteLine("The competition is bigger than ever!");
    }
    else if (thisYearContestants < lastYearContestants)
    {
        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
    }

    // Display the motto again after output
    DisplayMotto();
}

static int GetValidContestantCount(string prompt)
{
    int contestants;
    bool validInput = false;

    do
    {
        Console.Write(prompt);
        string input = Console.ReadLine();

        if (int.TryParse(input, out contestants) && contestants >= 0 && contestants <= 30)
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
        }
    } while (!validInput);

    return contestants;
}
