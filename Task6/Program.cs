// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

// double a = new Random().Next(1, 2);
// double b = new Random().NextDouble();
// double c = Math.Round(a + b, 2);
// Console.Write(c);

double[] array = new double[10];
for(int i = 0; i < array.Length; i++)
{
    double a = new Random().Next(1, 100);
    double b = new Random().NextDouble();
    array[i] = Math.Round(a + b, 2);
    Console.Write(array[i] + " ");
}
double max = array[0];
double min = array[0];
for(int i = 0; i< array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.Write($"=> {result}");