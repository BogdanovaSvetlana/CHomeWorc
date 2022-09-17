// Программа, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число!");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число!");

int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (a > b) max = a;
if (a < b) max = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);