//Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int x, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(x == arr[i])
        {
            return true;
        }
    }
    return false;
}

string ArrayToString(int[] arr)
{
    string r = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        r = r + $"{arr[i]}, ";
    }
    r = r + "]";
    return r;
}


int[] arr = {6, 7, 19, 345, 3, 62, 17, 11, 21};

int x = GetNumber();
// int y = GetNumber();
bool f = FindElement(x, arr);
// FindElement(y, arr);
string r = ArrayToString(arr);
Console.WriteLine($"{x}; массив {r} -> {f}");