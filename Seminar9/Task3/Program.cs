// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int CalculatingFunctionA(int m, int n) // A - Аккерман
{
    if (m == 0)
        return n + 1;
    else
    {
        if (m > 0 && n == 0)
            return CalculatingFunctionA(m - 1, 1);
        else
            return CalculatingFunctionA(m - 1, CalculatingFunctionA(m, n - 1));
    }
}


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0)
{
    int result = CalculatingFunctionA(m, n);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите неотрицательные числа m, n");
}

