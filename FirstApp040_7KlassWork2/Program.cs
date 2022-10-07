// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = i + j;
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}


int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);


// ВТОРОЙ ВАРИАНТ РЕШЕНИЯ
// int InputNumber(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Преобразование массива в строку с заданным разделителем
// string StringArray2(int[,] array, string split) 
// {
//     int lenght0 = array.GetLength(0); // получение длины массива
//     int lenght1 = array.GetLength(1); // получение длины массива
//     string textarray = String.Empty; // обнуление строки
//     for( int i = 0; i < lenght0; i++) // цикл по элементам массива
//     {
//         for(int j = 0; j < lenght1; j++)
//         {
//             textarray += array[i, j]; // добавление в строку значения текущего элемента массива
//             if(j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
//             textarray += split; // добавление разделителя между элементами в строку
//         }
//         textarray += "\n";
//     }
//     return textarray; // возврат значения элементов массива в виде полученной строки
// }

// void FillArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
// }


// int m = InputNumber("Введите первую размерность массива: ");
// int n = InputNumber("Введите вторую размерность массива: ");

// int[,] array = new int[m, n];
// FillArray(array);
// Console.WriteLine(StringArray2(array, ", "));
