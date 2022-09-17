Console.WriteLine("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

if ( x == 1)
{
    Console.WriteLine("Понедельник");
}

else if( x == 2)
{
    Console.WriteLine("Вторник");
}

else if( x == 3)
{
    Console.WriteLine("Среда");
}

else if( x == 4)
{
    Console.WriteLine("Чертверг");
}

else if( x == 5)
{
    Console.WriteLine("Пятница");
}

else if( x == 6)
{
    Console.WriteLine("Суббота");
}

else if( x == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.Write("Неверно задан номер, выберите другой номер в диапазоне от 1 до 7 и повторите попытку.");
}