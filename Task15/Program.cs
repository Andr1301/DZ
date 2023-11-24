// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int number1, int number2)
{
    if (number2 < 0) //Проверка условия натурального числа
    {
        Console.WriteLine("В данном промежутке натуральных чисел нет");
        return;
    }
    else if (number1 > number2) //Условие выхода из рекурсии
    {
        return;
    }
    else if (number1 < 0) //Убираем отрицательные числа из вывода, ноль оставляем посколько он может считаться натуральным
    {
        number1 = number1 - number1;
    }
    Console.Write(number1 + " ");

    ShowNumbers(number1 + 1, number2);
}
if (M > N)
{
    Console.WriteLine("Число M должно быть меньше числа N!");
}
else
{
    ShowNumbers(M, N);
}