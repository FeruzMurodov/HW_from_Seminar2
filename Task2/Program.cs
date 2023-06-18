/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
(Максимум 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int num = new Random().Next(0, 100000);
Console.WriteLine($"Сгенерированный номер: {num}");

if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    if (num > 99 && num < 1000)
    {
        int result = num % 10;
        Console.WriteLine($"Третья цифра: {result}");
    }
    if (num > 999 && num < 10000)
    {
        int result = num % 100 / 10;
        Console.WriteLine($"Третья цифра: {result}");
    }
    if (num > 9999 && num < 100000)
    {
        int result = num % 1000 / 100;
        Console.WriteLine($"Третья цифра: {result}");
    }
}