// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void sortArrRows(int[, ] array)
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows; 
    for (int i = 0; i < rows; i++)
    {
        bool sorted = false;
        while (!sorted) 
        {
            sorted = true;
            for (int j = 0; j < columns - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int el = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = el;
                    sorted = false;
                }
            }
        }
    }   
}

int m = GetNumberFromConsole("Введите первую размерность массива: ");
int n = GetNumberFromConsole("Введите первую размерность массива: ");

int[,] array = new int[m, n];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
sortArrRows(array);
PrintArray(array);