// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int second = 0;
if(99 < number && number < 1000)
{
    second = (number / 10) % 10;
    Console.WriteLine($"{number} -> {second}");
}
else
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число!!!");
}