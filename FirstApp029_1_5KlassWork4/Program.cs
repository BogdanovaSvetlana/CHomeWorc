﻿// //Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапазону
{
    int lenght = array.Length; // получение длины массива
    for(int i = 0; i < lenght; i++) // цикл по всем элементам массива
        array[i] = new Random().Next(min, max+1); // заполнение текущего элемента массиива случайным числом из заданного при вызове метода диапазона
}

string StringArray(int[] array, string split) // Преобразование массива в строку с заданным разделителем
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

int FindNumber(int[] arr, int find) // Поиск индекса элемента массива с заданным числом(если число не найдено, возвращает -1)
{
     for( int i = 0; i < arr.Length; i++) // цикл по всем элементам массива
     {
        if(arr[i] == find) // сравнение текущего элемента массива с искомым числом
            return i; // возврат индекса текущего элемента массива
     }
     return -1; // возврат -1, если элемент не найден
}


// Инициализация, заполнение и вывод массива
int[] array = new int[4];
FillArray(array,-9,9);
Console.WriteLine("Случайно заполненный массив: [" + StringArray(array, ", ") + "]");
// Инициализация и ввод числа для поиска в массиве
int number = 0;
Console.Write("Введите число для поиска в массиве: ");
number = Convert.ToInt32(Console.ReadLine());
// Поиск заданного числа в массиве и выдача результата
if (FindNumber(array,number)<0)
    Console.WriteLine("Число " + number + " в массиве не присутствует (НЕТ)");
else
    Console.WriteLine("Число " + number + " в массиве присутствует (ДА)");
