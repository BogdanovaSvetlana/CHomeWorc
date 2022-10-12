// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int el = new Random().Next(10, 99);
                if (FindElement(array, el)) continue;
                array[i, j, k] = el;
                k++;
            }
        }  
            
    }
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})  ");
            }
        Console.WriteLine();
        }
    }
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    l = InputNumber("Введите третью размерность массива: ");
if( m * n * l > 89)
{
    Console.Write("Размер массива больше размерности случайных ");
    Console.WriteLine("уникальных чисел. Введите другие значения размерности массива!");
}
else
{
    int[,,] array = new int[m, n, l];

    FillArray(array);
    Console.WriteLine();
    Console.WriteLine($"Массив размерom {m}*{n}*{l}");
    PrintArray(array);
}