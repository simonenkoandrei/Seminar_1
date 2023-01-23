//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
int b;
b = a % 2; 
if (b == 0 )
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}