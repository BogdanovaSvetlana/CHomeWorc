// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.
int creatNumber()
{
    int number = new Random().Next(100,999);
    return number;
}

int toNumber(int x)
{
    int y = x % 100;
    int result = y / 10;
    return result;
}

// void printNumbers()
// {
//    for (int i = 1; i <= 15; i++)
//       {
//        int b = creatNumber();
//        Console.WriteLine($"{b}  ->  {toNumber(b)}");
//       }
// }


int a = creatNumber();
Console.WriteLine($"{a}  ->  {toNumber(a)}");


// printNumbers();