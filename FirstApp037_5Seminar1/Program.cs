// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int GetNumber(string M)
{
    int numA = 0;
    while (numA <= 1)
    {
        Console.WriteLine($"Укажите, сколько чисел Вы хотите ввести {M}" );
        numA = Convert.ToInt32(Console.ReadLine());
    }
    return numA;
}

string StringArray(int[] array) 
{
    int lenght = array.Length; 
    string textarray = String.Empty; 
    for (int i = 0; i < lenght; i++) 
    {
        textarray += array[i]; 
        if (i < lenght - 1) 
        {
            textarray += ", ";
        }
    }
    return textarray; 
}

int m = GetNumber("M");
int r = 0;
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите число № {i + 1} " );
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
    if( x > 0)
    {
        r++;
    }
}


Console.WriteLine($"{StringArray(array)} -> {r}");