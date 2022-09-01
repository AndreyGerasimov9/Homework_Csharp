// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int N = 4;
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();
for (int i =0; i < N; i++)
{
    array[i] = rnd.Next(100, 1000);
    Console.Write($"{array[i]}  ");
}
Console.WriteLine();

int result = 0;
for (int i =0; i < N; i++)
{
    if (array[i]%2 == 0)
    {
        result = result + 1;
    }
}
Console.WriteLine(result);