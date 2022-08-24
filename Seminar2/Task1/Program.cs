int start = 100;
int stop = 1000;
int value = new Random().Next(start, stop);
Console.WriteLine(value);
int digit_second = value%100/10;
Console.WriteLine(digit_second);