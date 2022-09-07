// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, 10); // [1; 10)
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
// int[] array = {1, 3, 8, 3, 2};

int mult = 0;
int sum = 0;
for (int i = 0; i < N/2; i++)
{
    mult = array[i] * array[N - (i + 1)];
    sum = sum + mult;
}
Console.WriteLine(sum);