// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
//  Math.Sqrt(int a); Math.Pow(x,2);
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name + ":");
    return Convert.ToDouble(Console.ReadLine());
}

double GetNumChetv(double x1, double y1, double x2, double y2)
{
    double a = (x2 - x1);
    double a1 = Math.Pow(a, 2);

    double b = (y2 - y1);
    double b1 = Math.Pow(b, 2);

    double c = (a1 + b1);
    double result = Math.Sqrt(c);

    return result;
}

double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");

Console.WriteLine(GetNumChetv(x1, y1, x2, y2));

// int InputNumber(string C) // Ручной ввод координаты
// {
//     Console.Write($"Введите {C}: "); 
//     return Convert.ToInt32(Console.ReadLine()); 
// }

// double GetDistance(int X1, int Y1, int X2, int Y2) // Нахождение расстояния между двумя точками
// {
//     return Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
// }

// Console.WriteLine("Расстояние между точками: "+GetDistance(InputNumber("X1"),InputNumber("Y1"),InputNumber("X2"),InputNumber("Y2")));


// double GetNumber(string name)
// {
//     Console.WriteLine("Введите координаты " + name + ":");
//     return Convert.ToDouble(Console.ReadLine());
// }

// double GetNumChetv(double x1, double y1, double x2, double y2)
// {
//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

//     return result;
// }

// double x1 = GetNumber("x1");
// double y1 = GetNumber("y1");
// double x2 = GetNumber("x2");
// double y2 = GetNumber("y2");

// Console.WriteLine(GetNumChetv(x1, y1, x2, y2));
