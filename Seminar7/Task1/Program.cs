// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        twoDimArray[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        twoDimArray[i, j] = Math.Round(twoDimArray[i, j], 1);
        Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
}