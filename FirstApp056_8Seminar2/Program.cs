// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Преобразование массива в строку с заданным разделителем
string intArrayToString(int[,] array) 
{
    int lenght0 = array.GetLength(0); // получение длины массива
    int lenght1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for ( int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for (int j = 0; j < lenght1; j++)
        {
            textarray += array[i, j]; // добавление в строку значения текущего элемента массива
            if (j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += ", "; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

int printResalt(int[,] array)
{
    int minSum = Int32.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    return minIndex;
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


int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: ");
if (m != n)
{
    int min = InputNumber("Введите минимальное значение случайных чисел: "),
        max = InputNumber("Введите максимальное значение случайных чисел: ");
    int[,] array = new int[m, n];

    FillArray(array, min, max);
    Console.WriteLine();
    Console.WriteLine(intArrayToString(array));
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {printResalt(array)}");
}
else
{
    Console.WriteLine("Размерность массива указана неверно, одно из значений должно быть ");
    Console.WriteLine("больше другого. Укажите другие значения в следующий раз!");
}
