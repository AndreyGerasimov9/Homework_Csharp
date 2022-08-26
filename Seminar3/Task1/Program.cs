// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число для проверки, является ли оно полиндромом: ");
int n = Convert.ToInt32(Console.ReadLine());

int x1 = n / 10000;
int x2 = n / 1000 %10;
int x3 = n / 100 %10;
int x4 = n / 10 %10;
int x5 = n %10;

if (x1 == x5 && x2 ==x4) Console.WriteLine("да");
else Console.WriteLine("нет");