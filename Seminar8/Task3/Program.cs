// Сформируйте двухмерный массив из неповторяющихся двузначных чисел 
// (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.

void GenNonrepeatNumbers(int[] array)
{
    int start = 10;
    int stop = 100;
    if (array.Length <= stop - start)
    {
        Random rnd = new Random();
        array[0] = rnd.Next(start, stop);
        for (int i = 1; i < array.Length;)
        {
            int number = rnd.Next(start, stop);
            int j;
            for (j = 0; j < i; j++)
            {
                if (number == array[j])
                {
                    break;
                }
            }
            if (j == i)
            {
                array[i] = number;
                i++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0,3} ", array[i]);
            if (i % 10 == 9)
            {
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine("уменьшите размер массива");
    }
}  

int N = 50; // по условиям задачи
int[]arr1 = new int[N];
GenNonrepeatNumbers(arr1);
Console.WriteLine();

Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr2 = new int[m, n];
if (N >= n * m)
{
    int k = 0; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr2[i, j] = arr1[k];
            Console.Write("{0,3} ", arr2[i, j]);
            k++;
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("уменьшите размер массива m * n");
}
