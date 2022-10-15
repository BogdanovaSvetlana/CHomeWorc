// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

int getSum(int m, int n)
{
    int result = 0;
    for (int i = m; i <= n; i++)
    {
        result += i;
    }
    return result;
}


Console.WriteLine("Введите M:");
double m = GetNumberFromConsole();
Console.WriteLine("Введите N:");
double n = GetNumberFromConsole();
Console.WriteLine();
int r = getSum((int) Math.Ceiling(m), (int) n);
Console.Write($"M = {m}; N = {n} ->  {r}");
