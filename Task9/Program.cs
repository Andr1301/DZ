// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

int[,] array = new int[5, 5];
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1,10);
    }
}

for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите индекс 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a < array.GetLength(0) && b < array.GetLength(1))
{
    Console.WriteLine("Элемент = " + array[a, b]);
}
else
{
    Console.WriteLine("Введите корректные координаты!");
}