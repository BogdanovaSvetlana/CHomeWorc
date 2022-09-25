// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name + ":");
    return Convert.ToDouble(Console.ReadLine());
}

double GetNumChetv(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = (x2 - x1);
    double a1 = Math.Pow(a, 2);

    double b = (y2 - y1);
    double b1 = Math.Pow(b, 2);

    double c = (z2 - z1);
    double c1 = Math.Pow(c, 2);

    double r = (a1 + b1 + c1);
    double result = Math.Sqrt(r);

    return result;
}


double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
double z1 = GetNumber("z1");
double z2 = GetNumber("z2");

Console.WriteLine(GetNumChetv(x1, y1, x2, y2, z1, z2));
