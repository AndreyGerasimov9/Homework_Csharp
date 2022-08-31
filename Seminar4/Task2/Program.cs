// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе, которые являются делителями этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temporary = number;
int sum = 0;
while (temporary > 0)
{
    int digit = temporary%10;
    if (digit != 0)
    {
        if (number%digit == 0)
        {
            sum = sum + digit;
        }
    }
    temporary = temporary/10;
    
}
Console.WriteLine(sum);