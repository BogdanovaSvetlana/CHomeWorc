// SЗадача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int GetNumber() // Ручной ввод целого числа
{
    int num = 0;
    while (LengthNum(num) <= 2)
    {
    Console.WriteLine("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int LengthNum(int Number) // Получение количества цифр в числе
{
    int DigCount = 1;
    while(Math.Abs(Number/10)>0)
    {
        Number = Number / 10;
        DigCount++;
    }
    return DigCount;
}

int GetDigitFromNumber(int number, int index)
{
    int num = number/Convert.ToInt32(Math.Pow(10,LengthNum(number)-index))%10;
    return num;
}

int num = GetNumber();
Console.WriteLine("Вторая цифра: " + GetDigitFromNumber(num,2));
Console.WriteLine("Третья цифра: " + GetDigitFromNumber(num,3));
Console.WriteLine("Четвертая цифра: " + GetDigitFromNumber(num,4));
Console.WriteLine("Пятая цифра: " + GetDigitFromNumber(num,5));

// int InputNumber() // Ручной ввод целого числа
// {
//     Console.Write("Введите число: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int GetDigCont(int Number) // Получение количества цифр в числе
// {
//     int DigCount = 0;
//     //Number = Math.Abs(Number / 10);
//     while(Number > 0)
//     {
//         Number = Math.Abs(Number / 10);
//         DigCount++;
//     }
//     return DigCount;
// }


// Console.WriteLine("Количеств цифр в числе = " + GetDigCont(InputNumber()));