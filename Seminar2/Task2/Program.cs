int start = 1;
int stop = 65537;
int value = new Random().Next(start, stop);
Console.WriteLine(value);
int digit_third = 0;
if (value < 100000)
{
    digit_third = value/100%10;    
} 
if (value < 10000)
{
    digit_third = value/10%10;
}
if (value < 1000)
{
    digit_third = value%10;
}
if (value < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(digit_third);
}
