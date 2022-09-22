int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPow(int number)
{
    int index = 1;

    while (index <= number)
    {
        double a = Math.Pow(index, 2);
        Console.WriteLine(a);
        index++;
    }
}

GetPow(GetNumber());

