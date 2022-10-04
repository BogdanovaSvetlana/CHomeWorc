// Задача 39: Напишите программу, которая 
// перевернёт одномерный массив (последний элемент будет 
// на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,11);
    }
}

void PrintArray(int[] arr)
{
     Console.Write("[ "); // [ 1, 58, ...]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

int[] SwapArray(int[] arr)
{
    int[] tempArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {                // 5 - 1  0
        tempArr[arr.Length -1 -i] = arr[i];
    }
    return tempArr;
}

// void SwapArrayTwo(int[] arr)
// {
//     int swap;
//     for (int i = 0; i < arr.Length/2; i++)
//     {              
//         swap = arr[arr.Length-i-1];
//         arr[arr.Length-i-1] = arr[i];
//        arr[i] = swap;
//     }
// }

int[] array = new int[5];

FillArray(array);
PrintArray(array);
// Console.WriteLine("Метод №1");
PrintArray(SwapArray(array));
// Console.WriteLine("Метод №2");
// SwapArrayTwo(array);
// PrintArray(array);