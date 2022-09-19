int creatNumber()
{
    int number = new Random().Next(100,999);
    return number;
}

int MaxDigit(int number)
{
    int Sotni = number / 100;
    int Ed = number % 10;
    return Sotni * 10 + Ed;
}


int a = creatNumber();
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));
