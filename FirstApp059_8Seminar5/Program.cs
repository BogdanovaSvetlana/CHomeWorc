// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

void FillArray(int[,] array, int n)
{
    int num = 1;
    for (int padding = 0; padding < n - 2; padding++)
    {
        for (int i = 0 + padding; i < n - padding; i++)
        {
            array[0 + padding, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + padding; i < n - padding; i++)
        {
            array[i, n - 1 - padding] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - padding; i >= 0 + padding; i--)
        {
            array[n - 1 - padding, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - padding; i >= 1 + padding; i--)
        {
            array[i, 0 + padding] = num;
            num++;
        }
    }
}

int n = GetNumberFromConsole("Введите размер массива: ");

int[,] array = new int[n, n];


Console.WriteLine();
FillArray(array, n);
PrintArray(array);