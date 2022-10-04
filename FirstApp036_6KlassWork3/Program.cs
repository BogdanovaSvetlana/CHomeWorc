// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int GetNumber()
// {
// Console.WriteLine("Введите число!");
// return Convert.ToInt32(Console.ReadLine());
// }

// int a = GetNumber();
// Console.WriteLine(Convert.ToString(a,2));


int a = Convert.ToInt32(Console.ReadLine());
int temp = a;
int index = 0;
while (temp > 0)
{
    index++;
    temp /= 2;
}

int[] arr = new int[index];
// Console.WriteLine(index);
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = a % 2;
    a /= 2;
}

void PrintArray(int[] arr)
{
     Console.Write("[ "); // [ 1, 58, ...]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("]");
}

void SwapArrayTwo(int[] arr)
{
    int swap;
    for (int i = 0; i < arr.Length/2; i++)
    {              
        swap = arr[arr.Length-i-1];
        arr[arr.Length-i-1] = arr[i];
       arr[i] = swap;
    }
}


SwapArrayTwo(arr);
PrintArray(arr);