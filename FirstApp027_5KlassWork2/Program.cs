// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//  положительных чисел равна 29, сумма отрицательных равна -20.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
}

int getSummPositive(int[] arr)
{
    int summ = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            summ += arr[i];
        }
    }
    return summ;
}

int getSummNegative(int[] arr)
{
    int summ = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        {
            summ += arr[i];
        }
    }
    return summ;
}

int[] getSumms(int[] arr)
{
    int[] summArray = new int[2]; // [0] - сумма положительных, [1] - сумма отриц.
    summArray[0] = 0;
    summArray[1] = 0;

     for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            summArray[0] += arr[i];
        }
        
        if(arr[i] < 0)
        {
            summArray[1] += arr[i];
        }
    }
    return summArray;
}

int[] massiv = new int[12];

FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Сумма положительных: " + getSummPositive(massiv));
Console.WriteLine("Сумма отрицательных: " + getSummNegative(massiv));


int[] outMassiv = new int[2];

outMassiv = getSumms(massiv);

Console.WriteLine("Сумма положительных: " + outMassiv[0]);
Console.WriteLine("Сумма отрицательных: " + outMassiv[1]);


Console.WriteLine("Сумма положительных: " + getSumms(massiv)[0]);
Console.WriteLine("Сумма отрицательных: " + getSumms(massiv)[1]);