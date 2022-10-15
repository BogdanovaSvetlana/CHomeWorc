// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}


void WriteNumbersRecursionVoid(int number)
{
    Console.Write(number);
    if (number != 1)
    {
        Console.Write(", ");
    }
    if (number > 1)
    {
        WriteNumbersRecursionVoid(number-1);
    }    
}

Console.WriteLine("Введите N:");
double number = GetNumberFromConsole();

Console.WriteLine();
Console.Write($"N = {number} -> ");
WriteNumbersRecursionVoid((int)number);