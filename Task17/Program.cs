//  Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void FillArray(int[] array, int i)   //Заполяем массив случайными числами
{
    if (i == array.Length)
    {
        return;
    }

        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
        FillArray(array, i+1);

    return;
}
Console.WriteLine();
void ShowArrayReverse(int[] array, int i)   //Выводим массив в обратном порядке
{
    if (i == array.Length)
    {
        return;
    }

    ShowArrayReverse(array, i+1);
    Console.Write(array[i] + " ");
}
int[] numbers = new int[10];
FillArray(numbers, 0);
Console.WriteLine();
ShowArrayReverse(numbers, 0);