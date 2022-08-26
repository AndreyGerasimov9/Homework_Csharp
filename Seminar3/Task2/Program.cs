// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты точки А: Xa  ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya  ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Za  ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B: Xb  ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb  ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb  ");
int Zb = Convert.ToInt32(Console.ReadLine());
//int[] A = new int[] {3, 6, 8};
//int[] B = new int[] {2, 1, -7};
double AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
// AB = Math.Round(AB, 2);
Console.WriteLine(Math.Round(AB, 2));
