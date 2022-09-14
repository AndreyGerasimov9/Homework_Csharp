// Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FillMatrix(array);

int[] arrSum = new int[m];
int index = 0;
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[i, j];
    }
    arrSum [index] = sum;
    index++;
}
Console.WriteLine($"==========================");

for (int id = 0; id < m; id++)
{
    Console.Write($"{arrSum[id]}\t");
}
Console.WriteLine();
    
int ind = 0;
int min = arrSum[ind];
int pos = 0;
for (ind = 1; ind < m; ind++)
{
    if (arrSum[ind] < min)
    {
        min = arrSum[ind];
        pos = ind;
    } 
}
Console.WriteLine("Минимальная сумма элементов в строке: " + min);
Console.WriteLine($"Строка с наименьшей суммой элементов: {pos + 1} строка");
