// Найти сумму элементов от M до N, N и M заданы

void PrintElements(int m, int n)
{
    if (n < m) Console.Write($"");
    else
    {
        PrintElements(m, n - 1);
        Console.Write($"{n} ");
    }
}

double SumElements(int m, int n)
{
    if (n == m) return n;
    else return n + SumElements(m, n - 1);
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

System.Console.WriteLine($"Получаем последовательность чисел от {m} до {n}: ");
PrintElements(m, n);
Console.WriteLine();  
System.Console.Write($"Сумма чисел от {m} до {n} равна {SumElements(m, n)}");