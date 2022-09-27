// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetResult(int x)
{
    int r = 0;
    
    while (x > 0)
    {
        int y = x % 10;
        r = r + y;
        x = x / 10;
    }
    return r;
}

int x =  GetNumber();
GetResult(x);

Console.WriteLine($"{x} ->  {GetResult(x)}");