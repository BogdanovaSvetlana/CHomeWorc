// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int GetNumber()
{
    int num = 0;
    while (num <= 1)
    {
        Console.WriteLine("Введите число А (больше 1)!");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int GetSumm1toA(int A)
{
    int summ = 0;
    for (int i = 1; i <= A; i++)
    {
        summ += i;
    }
    return summ;
}


int A = GetNumber();

Console.WriteLine("Сумма чисел от 1 до " + A + " равна " + GetSumm1toA(A));