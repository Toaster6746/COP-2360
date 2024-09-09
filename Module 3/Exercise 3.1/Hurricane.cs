string mph = Console.ReadLine();
string mphNumberPart = mph.Remove(mph.IndexOf(' '));
float mphNum = float.Parse(mphNumberPart);
if (mphNum < 74)
{
    Console.WriteLine("Not a Hurricane");
}
else if (mphNum >= 74 && mphNum <= 95)
{
    Console.WriteLine("Category One Hurricane");
}
else if (mphNum >= 96 && mphNum <= 110)
{
    Console.WriteLine("Category Two Hurricane");
}
else if (mphNum >= 111 && mphNum <= 129)
{
    Console.WriteLine("Category Three Hurricane");
}
else if (mphNum >= 130 && mphNum <= 156)
{
    Console.WriteLine("Category Four Hurricane");
}
else
{
    Console.WriteLine("Category Five Hurricane");
}
