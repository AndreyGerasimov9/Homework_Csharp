int start = 1;
int stop = 1000000;
int value = new Random().Next(start, stop);
Console.WriteLine(value);
if (value%7 == 0)
{
    if (value%23 == 0)
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("нет");
}