// Напишите программу, которая принимает на вход пятизначное
//  число и проверяет, является ли оно палиндромом.
int oneNumber(int x1)
{
    int y1 = x1 / 10000;
    return y1;
}

int twoNumber(int x2)
{
    int y2 = x2 % 10000;
    int z1 = y2 / 1000;
    return z1;
}

int fourNumber(int x4)
{
    int y4 = x4 % 100;
    int z2 = y4 / 10;
    return z2;
}

int fiveNumber(int x5)
{
    int y5 = x5 % 10;
    return y5;
}


void printNumbers(int n)
{
    int a1 = oneNumber(n);
    int a2 = twoNumber(n);
    int a4 = fourNumber(n);
    int a5 = fiveNumber(n);
    if(a1 == a5 && a2 == a4)
    {
        Console.WriteLine($"{n} -> это палиндром");
    }
    else 
    {
        Console.WriteLine($"{n} -> это не палиндром");
    }
}

Console.WriteLine("Введите любое пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 9999 && n < 100000)
{
    printNumbers(n);
}
else
{
    Console.Write("Вы ввели неправильное число, введите пятизначное ");
    Console.WriteLine("число и повторите попытку");
}
