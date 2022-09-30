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


// void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапазону
// {
//     int lenght = array.Length;
//     for(int i = 0; i < lenght; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
// }

// string StringArray(int[] array, string split) // Преобразование массива в строку с заданным разделителем
// {
//     int lenght = array.Length;
//     string textarray = String.Empty;
//     for( int i = 0; i < lenght; i++)
//     {
//         textarray += array[i];
//         if(i < lenght - 1)
//         {
//             textarray += split;
//         }
//     }
//     return textarray;
// }

// void ChangeArray(int[] arr) // Замена элементов массива
// {
//      for( int i = 0; i < arr.Length; i++)
//      {
//         arr[i] *= -1;
//      }
// }

// int[] array = new int[20];
// FillArray(array,-9,9);
// Console.WriteLine("Случайно заполненный массив: [" + StringArray(array, ", ") + "]");
// ChangeArray(array);
// Console.WriteLine("Массив с заменой элементов: [" + StringArray(array, ", ") + "]");