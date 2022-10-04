// Задача 40: Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name + ":");
    return Convert.ToDouble(Console.ReadLine());
}

void GetResult(double a, double b, double c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Такой треугольник  не может существовать");
    }
}


double a = GetNumber("a");
double b = GetNumber("b");
double c = GetNumber("c");

GetResult(a, b, c);








// void FillArray(int[] arr) // Наполняем массив
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void CheckArray(int[] arr)
// {
//     int max = arr[0];
//     int indMax = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if(arr[i] > max)
//         {
//             max = arr[i];
//             indMax = i;
//             sum = sum + arr[i];
//         }  
//     }
// }


//     Console.WriteLine(sum);
//     Console.WriteLine(arr[indMax]);
//      sum = sum = arr[indMax];
//      Console.WriteLine(sum);
//      if(arr[indMax] < sum)
//      {
//         Console.WriteLine("Такой треугольник может существовать");
//      }
//     else
//     {
//         Console.WriteLine("Такой треугольник  не может существовать");
//     }
// }


// int[] array = new int[3];
// FillArray(array);
// CheckArray(array);