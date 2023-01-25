// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру,обозначающую день недели от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 6)
{
    Console.WriteLine("Нет");
}
else
    Console.WriteLine("Да");