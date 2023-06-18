/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет */

Console.WriteLine($"Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"Это выходной день");
    }
    else
    {
        Console.WriteLine($"Это НЕ выходной день");
    }
}
else
{
    Console.WriteLine($"Нет такого дня недели");
}