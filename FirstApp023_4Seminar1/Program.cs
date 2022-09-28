// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
int getNumberA()
{
    int numA = 0;
    while (numA <= 1)
    {
        Console.WriteLine("Введите положительное число A");
        numA = Convert.ToInt32(Console.ReadLine());
    }
    return numA;
}

int getNumberB()
{
    int numB = 0;
    while (numB <= 1)
    {
        Console.WriteLine("Введите положительное число B");
        numB = Convert.ToInt32(Console.ReadLine());
    }
    return numB;
}

int getStepen(int a, int b)
{
    int stepen = 1;
    for (int i = 0; i < b; i++)
    {
        stepen = stepen * a;
    }
    return stepen;
}


int a = getNumberA();
int b = getNumberB();
getStepen(a,b);
int r = getStepen(a,b);
Console.WriteLine($"{a},{b}  ->  {r}");

// int getStepen()
// {

//     int num = Convert.ToInt32(Math. Pow(A,B));
//     return num;
// }
