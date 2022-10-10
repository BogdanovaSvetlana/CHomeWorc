// Задача 2. Напишите программу для умножения массива
// различных размерностей на число.
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

int[,] getMult(int[,] array, int x)
{ 
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows; 
    int[,] mult = new int[rows,columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            mult[i, j] = array[i, j] * x;
        }
    }
    return mult;
}


int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    x = InputNumber("Введите число, на которое хотите умножить массив: "),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
if (min > max)
{
    Console.WriteLine("Вы ввели недопустимое значение, введите другое число в следующий раз!");
}
else
{
    int[,] array = new int[m, n];


    FillArray(array, min, max);
    int[,] mult = getMult(array, x);
    Console.WriteLine(StringArray(array, ", "));
    Console.WriteLine($"Результат умножения массива на число равен: ");
    Console.WriteLine(StringArray(mult, ", "));
}

