﻿// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a/10000 == a%10) && (a/1000%10 == a/10%10))
{
    Console.WriteLine($"{a} -> палиндром");
}
else
{
    Console.WriteLine($"{a} -> не палиндром");
}