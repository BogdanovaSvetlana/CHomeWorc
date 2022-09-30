// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
     Console.Write("[ "); // [ 1, 58, ...]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int GetSumm1toA(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            summ = summ + arr[i];
        }
    }
    return summ;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
int z = GetSumm1toA(array);
Console.Write($" -> {z}");

