const int numTemperatures = 5;
double[] temperatures = new double[numTemperatures];
double minTemp = -30;
double maxTemp = 130;
bool gettingWarmer = true;
bool gettingCooler = true;
bool invalidTemperature = false;  // Track if there's any invalid temperature
string invalidTempMessage = "";  // Store invalid temperature message

for (int i = 0; i < numTemperatures; i++)
{
    double temp = 0;  // Initialize temp here
    while (true)
    {
        try
        {
            Console.Write($"Enter temperature {i + 1} (between {minTemp} and {maxTemp}): ");
            temp = double.Parse(Console.ReadLine());

            // If temperature is out of range, throw an exception
            if (temp < minTemp || temp > maxTemp)
            {
                invalidTempMessage = $"Temperature {temp} is invalid, Please enter a valid temperature between {minTemp} and {maxTemp}";
                throw new Exception($"THROW Exception (check expected outcome)");
            }
            // If temperature is valid, break out of the loop
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);  // Display the exception message
            invalidTemperature = true;  // Mark the temperature as invalid
        }
    }
    temperatures[i] = temp;

    // Compare the temperatures to check order
    if (i > 0)
    {
        if (temperatures[i] > temperatures[i - 1])
        {
            gettingCooler = false;
        }
        else if (temperatures[i] < temperatures[i - 1])
        {
            gettingWarmer = false;
        }
        else
        {
            gettingWarmer = false;
            gettingCooler = false;
        }
    }
}

// Display the invalid temperature message if applicable
if (invalidTemperature)
{
    Console.WriteLine(invalidTempMessage);
}

// Determine the message based on the temperature trends
if (gettingWarmer)
{
    Console.WriteLine("Getting warmer");
}
else if (gettingCooler)
{
    Console.WriteLine("Getting cooler");
}
else
{
    Console.WriteLine("It's a mixed bag");
}

// Display temperatures and their average
Console.WriteLine($"5-day Temperatures: [{string.Join(", ", temperatures)}]");
double averageTemperature = temperatures.Average();
Console.WriteLine($"Average Temperature: {averageTemperature:F1} degrees");
