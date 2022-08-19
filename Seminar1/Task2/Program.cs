Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);