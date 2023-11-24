// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int Ackerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return (number2+1);
    }
    else if (number2 == 0)
    {
        return Ackerman (number1 - 1, 1);
    }
    else
    {
        return Ackerman(number1 - 1, Ackerman(number1, number2 - 1));
    }
}
if (m < 0 || n < 0)
{
    Console.WriteLine("Введите положительные числа m и n!");
}
else
{
    Console.WriteLine($"Функция Аккермана = {Ackerman(m, n)}");
}