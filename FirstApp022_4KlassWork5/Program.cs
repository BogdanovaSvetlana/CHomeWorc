// Задача 30: Напишите программу, которая
//  выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
   arr[i] = new Random().Next(0,2);
   Console.WriteLine(arr[i]);
}


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}


int[] array = new int[8];

FillArray(array);
PrintArray(array);

// int[] array1 = new int[] {1,2,3,4};
// int[] array2 = array1;
// PrintArray(array1);
// array1[0] = 5;
// Console.WriteLine();
// PrintArray(array2);