﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
(Проверка на трехзначность при вводе пользователем)
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine($"Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 99 && number < 1000)
{
    int result1 = (number - number / 100 * 100) / 10;
    Console.WriteLine($"Вторая цифра: {result1} ");
}
else
{
    Console.WriteLine($"Это НЕ трёхзначное число: ");
}