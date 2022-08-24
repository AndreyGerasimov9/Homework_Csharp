Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7, чтобы проверить, является ли этот день выходным: ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 6: Console.WriteLine("да");
    break;
    case 7: Console.WriteLine("да");
    break;
    default: Console.WriteLine("нет");
    break;
}
