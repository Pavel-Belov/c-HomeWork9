// Написать программу вычисления функции Аккермана

double Ackerman(double n, double m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}

// Console.Write("Введите n: ");
// double n = double.Parse(Console.ReadLine());
// Console.Write("Введите m: ");
// double m = double.Parse(Console.ReadLine());

// Наибольшие значения n = 10 или m = 3
// При больших значениях n и m переполняется стек
double n = 10;
double m = 3;

Console.WriteLine($"Функция Аккермана A({n},{m}):");
if (n >= 0 && m >= 0)
{
    for (int i = 0; i <= n; i++)
    {
        for (int j = 0; j <= m; j++)
        {
            Console.Write($"{Ackerman(j, i)} ");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Числа должны быть неотрицательные!");