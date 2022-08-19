Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < N - 1)
{
    count = count + 2;
    Console.Write(count);
}