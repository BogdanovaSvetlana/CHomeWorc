// Метод, который умножает число на число и возвращает результат
// int GetMulti( int a, int b)
// {
//     return a * b;
// }

// //  *******************************
// // ОСНОВНАЯ ПРОГРАММА
// int number1 = new Random().Next(0,100);
// int number2 = new Random().Next(0,100);

// Console.WriteLine(GetMulti(number1,number2));
// // *************************************

double GetMulti( int a, double b)
{
    return a * b;
}


int zp = 5000000;
double index = 1.1;

Console.WriteLine(GetMulti(zp,index));


int kolProd = 10;
double kolVint = 50;

Console.WriteLine(GetMulti(kolProd,kolVint));