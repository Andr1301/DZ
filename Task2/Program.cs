﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
//int threenum = 0;
if(number > 99)
{
    if(number < 1000)
    {
        Console.WriteLine(number % 10);
    }
    else
    {
        while(number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}