// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] GenerateArray()
{
    Console.WriteLine("Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row,col];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] GenerateArray2(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int min = array[minI,minJ];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
                min = array[i,j];
                minI = i;
                minJ = j;
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine(minI);
    Console.WriteLine(minJ);
    Console.WriteLine();
    int[,] array2 = new int[(array.GetLength(0)-1), (array.GetLength(1)-1)];
    for(int i=0; i<array2.GetLength(0); i++)
    {
        for(int j = 0; j<array2.GetLength(1); j++)
        {
            if(i<minI && j<minJ)
            {
                array2[i,j] = array[i,j];
                Console.Write(array2[i,j] + "\t");
            }
            else if(i>=minI && j<minJ)
            {
                array2[i,j]  = array[i+1,j];
                Console.Write(array2[i,j] + "\t");
            }
            else if(i<minI && j>=minJ)
            {
                array2[i,j]  = array[i,j+1];
                Console.Write(array2[i,j] + "\t");
            }
            else if(i>=minI && j>=minJ)
            {
                array2[i,j]  = array[i+1,j+1];
                Console.Write(array2[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
    return array2;
}

int[,] array = GenerateArray();
int[,] array2 = GenerateArray2(array);