// Программа, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите верхнюю границу диапазона!");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат: ");
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
