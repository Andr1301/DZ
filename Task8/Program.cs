﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void SumNumber(int N){
int sum = 0;
while((N / 10) > 0)
{
    sum = sum + (N % 10);
    N = N / 10;
}
sum = sum + N;
Console.WriteLine(sum);
}

SumNumber(number);