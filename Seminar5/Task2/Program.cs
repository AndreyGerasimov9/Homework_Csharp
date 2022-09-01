// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях 
// (позиция - индекс элемента в массиве).
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();
for (int i =0; i < N; i++)
{
    array[i] = rnd.Next(1, 100);
    Console.Write($"{array[i]}  ");
}
Console.WriteLine();

int sum = 0;
for (int i =1; i < N; i = i + 2)
{
    if (array[i]%2 == 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine(sum);