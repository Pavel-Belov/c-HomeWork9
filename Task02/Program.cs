// Показать натуральные числа от M до N, N и M заданы

void NaturalNums(int m, int n)
{
    if (n < m) Console.Write($"");
    else
    {
        NaturalNums(m, n - 1);
        Console.Write($"{n} ");
    }
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (m > 0 && n > 0)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    System.Console.WriteLine($"Натуральные числа от {m} до {n}:");
    NaturalNums(m, n);
}
else Console.WriteLine("Ошибка. Натуральным является число больше нуля!");