﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A :" );
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B :" );
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int res = 1;
while ( i <= b)
{
   res = res * a;
   i++;
}
Console.WriteLine(res);