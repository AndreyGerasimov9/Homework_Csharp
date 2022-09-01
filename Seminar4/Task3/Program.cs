// (Дополнительная, не обязательная задача): Назовём число «интересным» 
// если его произведение цифр делится на их сумму. Напишите программу, 
// которая заполняет массив на N «интересных» случайных целых чисел. 
// (Каждый эл-т массива должен быть сгенерирован случайно)

int GeneratingInterestingNumbers()
{
    int x = 1;
    int number = 0;
    Random rnd = new Random();
    while (x != 0)
    {
        number = rnd.Next(1, 1000);
        // Console.WriteLine(number);
        int tmp = number;
        int sum = 0;
        int mult = 1;
        while (tmp > 0)
        {
            int digit = tmp % 10;
            if (digit != 0)
            {
                sum = sum + digit;
                mult = mult * digit;
            }
            tmp = tmp / 10;
        }
        x = mult % sum;
    }
    return number;
}
//int newnumber = InterestingNumbers();
//Console.WriteLine(newnumber);

//int N = 5;
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i = 0;
while (i < N)
{
    int new_interesting_number = GeneratingInterestingNumbers();
    array[i] = new_interesting_number;
    Console.Write($"{array[i]}  ");
    i++;
}
