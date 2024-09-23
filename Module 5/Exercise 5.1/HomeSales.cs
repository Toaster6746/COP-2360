        char[] salespersons = { 'D', 'E', 'F' };
        double[] sales = new double[salespersons.Length];

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

            // Check if the salesperson exists in the array
            int index = Array.IndexOf(salespersons, salesperson);
            if (index >= 0)
            {
                // Prompt for the sale amount
                Console.Write("Sale amount: ");
                double saleAmount;
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount >= 0)
                {
                    // Add the sale to the corresponding salesperson's total
                    sales[index] += saleAmount;
                    grandTotal += saleAmount;

                    // Check if this salesperson now has the highest total
                    if (sales[index] > highestSale)
                    {
                        highestSale = sales[index];
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
