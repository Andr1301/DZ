// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9

int[,] array = new int[5, 6];
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
int MinSum = 0;
int index = 0;
for(int j = 0; j<array.GetLength(1); j++)
{
    MinSum += array[0, j];
}
for(int i = 1; i<array.GetLength(0); i++)
{
    int sum = 0;
    for(int j=0; j<array.GetLength(1); j++)
    sum += array[i, j];
    if(sum < MinSum)
    {
        index = i;
        MinSum = sum;
    }
}
Console.WriteLine("Min = " + index);