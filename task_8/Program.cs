//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= N)
{
    Console.WriteLine(a + 1);
    a = a + 2;  
}
