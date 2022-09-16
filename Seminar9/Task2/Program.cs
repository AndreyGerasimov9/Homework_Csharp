// Напишите программу, которая заполнит спирально двумерный массив 4 на 4.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3} ", array[i, j]); 
        }
        Console.WriteLine();
    }
}

int m = 4; // по условиям задачи
int n = 4; // по условиям задачи
int[,] arr2 = new int[m, n];
int i = 0;
int j = 0;
for (int num = 1; num <= m * n;)
{
    arr2[i, j] = num;
    num++;
    if (i <= j + 1 && i + j < n - 1)
    {
        j++;
    }   
    else if (i < j && i + j >= m - 1)
    {
        i++;
    }   
    else if (i >= j && i + j > n - 1)
    {
        j--;
    }   
    else
    {
        i--;
    }
        
}

PrintArray(arr2);


