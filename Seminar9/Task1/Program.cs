// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr2 = new int[m, n];

FillArray(arr2);
PrintArray(arr2);
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n - 1; k++)
        {
            if (arr2[i, k] < arr2[i, k + 1])
            {
                int temp = arr2[i, k + 1];
                arr2[i, k + 1] = arr2[i, k];
                arr2[i, k] = temp;
            }
        }
    }
}
PrintArray(arr2);