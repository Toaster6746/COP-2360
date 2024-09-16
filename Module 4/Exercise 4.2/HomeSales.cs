Dictionary<char, double> sales = new Dictionary<char, double>() {
            { 'D', 0 },
            { 'E', 0 },
            { 'F', 0 }
        };
        char highestSalesperson = ' ';
        double grandTotal = 0;
        double highestSale = 0;

        // Loop until the user types Z or z
        while (true)
        {
            Console.Write("Salesperson (D, E, F, Z to quit): ");
            char salesperson = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (salesperson == 'Z')
                break;

            if (sales.ContainsKey(salesperson))
            {
                // Prompt for the sale amount
                Console.Write("Sale amount: ");
                double saleAmount;
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount >= 0)
                {
                    // Add the sale to the corresponding salesperson's total
                    sales[salesperson] += saleAmount;
                    grandTotal += saleAmount;

                    // Check if this salesperson now has the highest total
                    if (sales[salesperson] > highestSale)
                    {
                        highestSale = sales[salesperson];
                        highestSalesperson = salesperson;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid sale amount. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
            }
        }

        // Display results
        Console.WriteLine($"Grand Total: ${grandTotal:N}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
