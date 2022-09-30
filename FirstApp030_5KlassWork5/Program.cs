// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200,201);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

void SerchArray(int[] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 99 && array[i] >= 10)
        count ++;
    }
    Console.WriteLine(" Количество элементов масива от 10 до 99 - " + count);
}


int[] array = new int[123];
FillArray(array);
PrintArray(array);


SerchArray(array);