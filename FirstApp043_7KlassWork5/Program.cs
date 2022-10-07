// Задача: Задать массив случайных чисел mxn
// Затем, транспонировать массив - превратить в новый, размером nxm
// Пример:
// 0 1 2 3
// 4 5 6 7
// Станет
// 0 4 
// 1 5
// 2 6 
// 3 7
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Преобразование массива в строку с заданным разделителем
string StringArray2(int[,] array, string split) 
{
    int lenght0 = array.GetLength(0); // получение длины массива
    int lenght1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for( int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for(int j = 0; j < lenght1; j++)
        {
            textarray += array[i, j]; // добавление в строку значения текущего элемента массива
            if(j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += split; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

void FillArray(int[,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
}

int[,] Transposition(int[,] array)
{
    int[,] result = new int[array.GetLength(1), array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}


int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
int[,] array = new int[m, n];


FillArray(array, min, max);
Console.WriteLine(StringArray2(array, ", "));
Console.WriteLine();
int[,] arrayT = Transposition(array);
Console.WriteLine(StringArray2(arrayT, ", "));
