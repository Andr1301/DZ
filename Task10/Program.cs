// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9 => 2 6 9
// 4 6 2 => 4 3 1

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
int a = 0;
for(int j = 0; j<array.GetLength(1); j++)
{
    a = array[0, j];
    array[0, j] = array[(array.GetLength(0)-1), j];
    array[(array.GetLength(0)-1), j] = a;
}
    Console.WriteLine();
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}