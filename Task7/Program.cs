// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double B = Convert.ToDouble(Console.ReadLine());

void Pow (double A, double B)
{
    if (B < 1)
    {
        Console.WriteLine("Значение B должно быть натуральным числом (>0)");
    }
    else
    {
        Math.Round(B);
        Console.WriteLine($"{A} в степени {B} = " + Math.Pow(A, B));
    }
}
Pow(A, B);