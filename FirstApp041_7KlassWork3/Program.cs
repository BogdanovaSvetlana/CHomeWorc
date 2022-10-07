// Задача 49: Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса чётные, и замените эти 
// элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

void PowEvenIndexElements(int[,] arr)
{
        for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i+1) % 2 == 0 && (j+1) % 2 == 0)
            {
                arr[i,j] = Convert.ToInt32(Math.Pow(arr[i,j], 2));
            }
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


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
PowEvenIndexElements(array);
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

// void FillArray(int[,] array, int min, int max)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// void ArrayChange(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if((i+1) % 2 == 0 && (j+1) % 2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//     }
// }


// int m = InputNumber("Введите первую размерность массива: "),
//     n = InputNumber("Введите вторую размерность массива: "),
//     min = InputNumber("Введите минимальное значение случайных чисел: "),
//     max = InputNumber("Введите максимальное значение случайных чисел: ");
// int[,] array = new int[m, n];


// FillArray(array, min, max);
// Console.WriteLine(StringArray2(array, ", "));
// Console.WriteLine();
// ArrayChange(array);
// Console.WriteLine(StringArray2(array, ", "));