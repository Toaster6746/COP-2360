string hours = Console.ReadLine();
string hoursNumberPart = hours.Remove(hours.IndexOf(' '));
int hoursNum = int.Parse(hoursNumberPart);
string miles = Console.ReadLine();
string milesNumberPart = miles.Remove(miles.IndexOf(' '));
int milesNum = int.Parse(milesNumberPart);
Console.WriteLine("$" + (200 + (milesNum * 2) + (hoursNum * 150)));
