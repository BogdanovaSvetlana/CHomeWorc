// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    for( int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for(int j = 0; j < lenght1; j++)
        {
            textarray += array[i, j]; // добавление в строку значения текущего элемента массива
            if(j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += ", "; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

string doubleArrayToString(double[] array) 
{
     int lenght = array.Length; // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for( int i = 0; i < lenght; i++) // цикл по элементам массива
    {
        textarray += Math.Round(array[i], 2); // добавление в строку значения текущего элемента массива
        if(i < lenght - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += ", "; // добавление разделителя между элементами в строку
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

double[] divArraus(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows; 
    double[] div = new double[columns];
    for(int j = 0; j <columns; j++)
    {
        int sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double avg = (double) sum / rows;
        div[j] = avg; 
    }
    return div;
}


int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
int[,] array = new int[m, n];


FillArray(array, min, max);
double[] div = divArraus(array);

Console.WriteLine(intArrayToString(array));
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
Console.WriteLine(doubleArrayToString(div));
