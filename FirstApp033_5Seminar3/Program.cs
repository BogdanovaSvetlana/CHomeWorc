// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
     Console.Write("[ "); // [ 1, 58, ...]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) 
        {
            max = array [i];
        }
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) 
        {
            min = array [i];
        }
    }
    return min;
}

double[] array = new double[10];

FillArray(array);
PrintArray(array);
double a = GetMax(array);
double b = GetMin(array);
double z = a - b;
Console.Write($" -> {z}");