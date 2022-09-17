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
