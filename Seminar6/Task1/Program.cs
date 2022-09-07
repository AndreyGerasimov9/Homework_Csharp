// Программа запрашивает натуральное число M, 
// пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int quantity = 0;
for (int i =0; i < M; i++)
{
    Console.Write("Введите число ");
    //array[i] = int.Parse(Console.ReadLine());
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        quantity++;
    }
}
//int[] array = {-1, -7, 567, 89, 223, 0}; // M = 6
Console.WriteLine("Количество чисел больше 0: " + quantity);