// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} -> ");
for (int a = 1; a <= N; a++)
{
    if (a != N)
    {
    Console.Write($"{Math.Pow(a,3)}, ");
    }
    else 
    {
    Console.Write($"{Math.Pow(a,3)}. "); 
    }
}