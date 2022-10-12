// Написать рекурсивный метод для деления одного числа на другое.
//  Нужен остаток и результат деления
int countSets = 0;
int getNumber(int z)
{
    Console.WriteLine($"Введите {z} -е целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int divisionRemainder(int x, int y)
{
    countSets++;
    if(x >= y)
    {
        x -= y;
        return divisionRemainder(x, y);
    }
    else
    {
        return x;
    }
}

int divisionFull(int x, int y)
{
    if(x >= y)
    {
        x -= y;
        return divisionFull(x, y) + 1;
    }
    else
    {
        return 0;
    }
}

int a = 1;
int b = 2;

int x = getNumber(a);
int y = getNumber(b);

Console.WriteLine(
    $"{x} / {y} = {divisionFull(x, y)} остаток от деления = {divisionRemainder(x, y)}"
);
Console.WriteLine($"Количество проходов: {countSets}");
