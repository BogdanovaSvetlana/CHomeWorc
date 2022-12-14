// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Преобразование массива в строку с заданным разделителем
string StringArray(int[,] array, string split) 
{
    int lenght0 = array.GetLength(0); // получение длины массива
    int lenght1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for (int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for (int j = 0; j < lenght1; j++)
        {
            textarray += array[i, j]; // добавление в строку значения текущего элемента массива
            if (j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += split; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
}

int[,] getMult(int[,] array1, int[,] array2)
{
    int[,] mult = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            mult[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                mult[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return mult;
}


int m = InputNumber("Введите первую размерность массива1: ");
int n = InputNumber("Введите вторую размерность массива1: ");
int a = InputNumber("Введите первую размерность массива2: ");
int b = InputNumber("Введите вторую размерность массива2: ");
if ( m != b)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    
}
else
{
    int min = InputNumber("Введите минимальное значение случайных чисел: ");
    int max = InputNumber("Введите максимальное значение случайных чисел: ");
    if (min > max)
    {
        Console.WriteLine("Вы ввели недопустимое значение, введите другое число в следующий раз!");
    }
    else
    {
        int[,] array1 = new int[m, n];
        int[,] array2 = new int[a, b];

        FillArray(array1, min, max);
        FillArray(array2, min, max);
        int[,] mult = getMult(array1, array2);
        Console.WriteLine(StringArray(array1, ", "));
        Console.WriteLine(StringArray(array2, ", "));
        Console.WriteLine("Произведение двух двумерных массивов равно: ");
        Console.WriteLine(StringArray(mult, ", "));
    }
}