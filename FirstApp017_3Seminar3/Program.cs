//Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void GetPow(int x)
{
    int index = 1;
    Console.Write($"{x} -> ");

    while (index <= x)
    {
        int a = index * index * index;
        Console.Write($"{a}, ");
        index++;
    }

}


GetPow(GetNumber());
