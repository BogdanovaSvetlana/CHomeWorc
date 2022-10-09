// Задача 4. Напишите программу для деления двух
// двумерных массивов.
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Преобразование массива в строку с заданным разделителем
string intArrayToString(int[,] array, string split) 
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

string doubleArrayToString(double[,] array, string split) 
{
    int lenght0 = array.GetLength(0); // получение длины массива
    int lenght1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for( int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for(int j = 0; j < lenght1; j++)
        {
            textarray += Math.Round(array[i, j], 2); // добавление в строку значения текущего элемента массива
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

double[,] divArraus(int[,] array1, int[,] array2)
{
    int rows = array1.GetUpperBound(0) + 1;   
    int columns = array1.Length / rows; 
    double[,] div = new double[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j <columns; j++)
        {
            div[i,j] = (double)array1[i, j] / array2[i, j];
        }
    }
    return div;
}


int m = InputNumber("Введите первую размерность массива: ");
int n = InputNumber("Введите вторую размерность массива: ");
int min = InputNumber("Введите минимальное значение случайных чисел: ");
int max = InputNumber("Введите максимальное значение случайных чисел: ");
if (min > max)
{
    Console.WriteLine("Вы ввели недопустимое значение, введите другое число в следующий раз!");
}
else
{
    int[,] array1 = new int[m, n];
    int[,] array2 = new int[m, n];

    FillArray(array1, min, max);
    FillArray(array2, min, max);
    double[,] div = divArraus(array1, array2);
    Console.WriteLine(intArrayToString(array1, ", "));
    Console.WriteLine(intArrayToString(array2, ", "));
    Console.WriteLine("Результат деления двух массивов равен: ");
    Console.WriteLine(doubleArrayToString(div, ", "));
}