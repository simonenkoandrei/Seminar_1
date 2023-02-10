// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
Console.Write("Введите x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance3D = Math.Sqrt((Math.Pow((x2 - x), 2)) + (Math.Pow((y2 - y), 2)) + (Math.Pow((z2 - z), 2)));
Console.WriteLine($"{Math.Round(distance3D, 2)}");