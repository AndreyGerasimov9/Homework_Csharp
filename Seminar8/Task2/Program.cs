// Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.

void FillSquareMatrix(int[,] matr, int q)
{
    int m = q;
    int n = m;
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = rnd.Next(1, 10);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк квадратной матрицы m: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

int[,] matrixA = new int[m, n];
FillSquareMatrix(matrixA, m);
Console.WriteLine();
int[,] matrixB = new int[m, n];
FillSquareMatrix(matrixB, m);
Console.WriteLine($"===========");


int[,] resultMatrixC = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {   
        int mult = 0;
        int sum = 0;
        for (int r = 0; r < n; r++)
        {
            mult = matrixA[i, r] * matrixB[r, j];
            sum = sum + mult;
        }
        resultMatrixC[i, j] = sum;
        Console.Write(resultMatrixC [i, j] + " ");
    }
    Console.WriteLine();
}