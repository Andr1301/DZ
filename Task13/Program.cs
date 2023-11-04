// Задача 41 : Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь

// Пример 0,7,8,-2,-2 -> 2
// -1,-7,567,89,223 -> 3

int[] GenerateArray()
{
    Console.WriteLine("Введите числа через ,");
    string input = Console.ReadLine(); //"12,24,35,46,13" => ["12", "24" , "35" , "46" , "13"] => [12, 24, 35, 46, 13]
    string[] arrayNumbers = input.Split(",");
    int[] numbers = new int[arrayNumbers.Length];
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(arrayNumbers[i]);
    }
    return numbers;
}
void Minus(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
         n++;
        }
    }
    Console.Write($"Количество отрицательных чисел = {n}");
}

int[] array = GenerateArray();
Console.WriteLine();
Minus(array);