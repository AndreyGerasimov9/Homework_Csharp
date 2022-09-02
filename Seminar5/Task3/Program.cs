// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// int[] arr = { 3, 7, 22, 2, 78 };
int N = 5;
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.Write($"{arr[i]}  ");
}
Console.WriteLine();

int FindMax(int[] array)
{
    int count = array.Length;
    int i = 0;
    int maximum = array[i];
    for (i = 1; i < count; i++)
    {
         if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }
    return maximum;
}
int max = FindMax(arr);
Console.WriteLine("max: " + max);

int FindMin(int[] array)
{
    int count = array.Length;
    int i = 0;
    int minimum = array[i];
    for (i = 1; i < count; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    return minimum;  
}
int min = FindMin(arr);
Console.WriteLine("min: " + min);

int result = max - min;
Console.WriteLine("result: " + result);