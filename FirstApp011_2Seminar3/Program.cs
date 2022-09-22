// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
void week(int x)
{
    if(x == 6 || x == 7)
    {
        Console.WriteLine($"{x}  ->  да ");
    }
    else if( x >= 1 & x < 6)
    {
        Console.WriteLine($"{x}  ->  нет ");
    }
    else 
    {
    Console.Write("Неверно задан номер, выберите другой номер в диапазоне от 1 до 7 и повторите попытку.");
    }
}

Console.WriteLine("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

week(x);