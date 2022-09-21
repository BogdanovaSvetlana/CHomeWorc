// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
int numLen(int x)
{
    int i = 0;
    while(x > 0)
    {
        x = x / 10;
        i++;
    }
    return i;
}


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int s = numLen(x);


if(s >= 3)
{
    int d1 = Convert.ToInt32(Math.Pow(10, s - 2));
    int d2 = Convert.ToInt32(Math.Pow(10, s - 3));
    int y = x % d1;
    int z = y / d2;
    Console.WriteLine($"{x}  ->  {z}");
}
else
{
    Console.WriteLine($"{x}  ->  третьей цифры нет ");
}