// Программа, которая на вход принимает три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число!");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число!");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число!");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (b > max) max = b;
if (c > max) max = c;
if (a < min) min = a;
if (c < min) min = c;


Console.Write("max = ");
Console.WriteLine(max);