// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int GetNumber(string M)
{
    Console.WriteLine($"Укажите, сколько чисел Вы хотите ввести  {M}" );
    return Convert.ToInt32(Console.ReadLine());
}

int r = 0;
for(int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите число № {i} " );
    int x = Convert.ToInt32(Console.ReadLine());
    if( x > 0)
    {
        r++;
    }
}

int Numbers(int[] array)
{
    int[] array[i] = 0;
    for(int i = 0; i < m; i++)
    {
        Console.Write(array[i] + "  " -> );
    }
    Console.WriteLine();
}

int m = GetNumber("M");
Numbers(array);
Console.WriteLine(r);