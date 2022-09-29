// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 
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

void getProizv(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = -1 * arr[i];
    }
    
}



int[] array = new int[20];

FillArray(array);
PrintArray(array);
getProizv(array);
PrintArray(array);

