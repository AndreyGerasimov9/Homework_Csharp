// Напишите программу, которая на вход принимает позиции (две) элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

//int[,] array = new int[3, 4] { { 1, 4, 7, 2}, { 5, 9, 2, 3}, { 8, 4, 2, 4} };

void SearchElementTwoDimArray(int[,] matrix)
{
    Console.Write("Введите позицию строки элемента rowIndex: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию столбца элемента columnIndex: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());
    if (rowIndex < matrix.GetLength(0) && columnIndex < matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == rowIndex && j == columnIndex)
                {
                    Console.Write($"Значение элемента в массиве: {matrix[i, j]}");
                    Console.WriteLine();
                }
            }  
        }
    }
    else 
    {
        Console.WriteLine("Такого элемента в массиве нет");              
    }                               
}

int[,] array = new int[3, 4];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

SearchElementTwoDimArray(array);
