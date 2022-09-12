// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] twoDimArray = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        twoDimArray[i, j] = rnd.Next(1, 10);
        Console.Write(twoDimArray[i, j] + "    ");
    }
    Console.WriteLine();
}
double average = 0;
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + twoDimArray[i, j];
    }
    average = sum/m;
    average = Math.Round(average, 1);
    Console.Write(average + "; ");
}
Console.WriteLine();