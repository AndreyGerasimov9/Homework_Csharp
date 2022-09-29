// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

string[] arr1 = new string[] { "Hello", "2", "world", ":-)" }; //по условиям задачи
PrintArray(arr1);

string[] arr2 = new string[arr1.Length];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3) //по условиям задачи
    {
        arr2[j] = arr1[i];
        j++;
    }
}
    
PrintArray(arr2);