// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// int GetNumber()
// {
//     Console.WriteLine("Введите число: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }

// int GetPow(int x)
// {
//     int p = 1;
//     Console.Write($"{x} -> ");

//     for (int i = 1; i <= x; i++)
//     {
//         p *= i;
//     }
//     return p;
// }


// int a = GetPow(GetNumber());

// Console.WriteLine(GetPow(a));


int GetNumber()
{
    int num = 0;
    while (num <= 1)
    {
        Console.WriteLine("Введите положительное число");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int GetProizv1toA(int A)
{
    int proizv = 1;
    for (int i = 1; i <= A; i++)
    {
        proizv = proizv * i;
    }
    return proizv;
}

int A = GetNumber();
Console.WriteLine("Произведение чисел от 1 до " + A + " = " + GetProizv1toA(A));
