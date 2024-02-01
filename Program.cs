// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AccermanFunction(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = AccermanFunction(n, m - 1);
        }
        n--;
    }
    return m + 1;
}


Console.Clear();
Console.Write("Введите неотрицательное число m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число n ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AccermanFunction(n, m);

Console.WriteLine($"Функция Аккермана ({n},{m}) равна {result}");

