//Интерполяция строк
int a = 5;
int b = 2;

Console.WriteLine($"Переменные: a={a}, b={b}");

//Рандомное вещественное число от 0 до 100
double number = new Random().NextDouble();
double number1 = new Random().NextDouble();
double number2 = new Random().NextDouble();

Console.WriteLine("Числа: " + Math.Round(number*100,2) + " " + number1*100 + " " + number2*100);
