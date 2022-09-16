// Напишите программу, которая заполнит спирально двумерный массив 4 на 4.

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

for (i = 0; i < m; i++)
  {
    for (j = 0; j < n; j++)
    {
        Console.Write("{0,3} ", arr2[i, j]); 
    }
    Console.WriteLine();
  }

