// Мои общие функции:

// Функция, формирует 3-х значное число и возвращает его
int creatNumber() 
{
    int number = new Random().Next(100,999);
    return number;
}

// Функция, формирует введенное с консоли число и возвращает его
int GetNumber() 
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());
}

// Получение количества цифр в числе
int LengthNum(int Number) 
{
    int DigCount = 1;
    while(Math.Abs(Number/10)>0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}

// Функция, формирует массив из 8 элементов
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,9);
    }
}

// Функция, формирует вывод на экран масива, который передается в нее
void PrintArray(int[] arr)
{
     Console.Write("[ "); // [ 1, 58, ...]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

// Функция, позволяет заменить положительные элементы массива
//(который в нее передвается) на отрицательные
void getProizv(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = -1 * arr[i];
    }
    
}

// Преобразование массива в строку с заданным разделителем
string StringArray(int[] array, string split) 
{
    int lenght = array.Length; // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for( int i = 0; i < lenght; i++) // цикл по элементам массива
    {
        textarray += array[i]; // добавление в строку значения текущего элемента массива
        if(i < lenght - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += split; // добавление разделителя между элементами в строку
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

// Поиск индекса элемента массива с заданным числом(если число 
// не найдено, возвращает -1)
int FindNumber(int[] arr, int find) 
{
     for( int i = 0; i < arr.Length; i++) // цикл по всем элементам массива
     {
        if(arr[i] == find) // сравнение текущего элемента массива с искомым числом
            return i; // возврат индекса текущего элемента массива
     }
     return -1; // возврат -1, если элемент не найден
}

// функция, принимает на вход массив и возвращает количество четных элементов
int FindElements(int[] arr)
{
    int z = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            z++;
        }
    }
    return z;
}

// функция, принимает на вход массив и возвращает сумму 
// элементов, стоящих на нечет.позициях
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            summ = summ + arr[i];
        }
    }
    return summ;
}

// Функция, принимает массив и находит максим. элемент в массиве
double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) 
        {
            max = array [i];
        }
    }
    return max;
}
