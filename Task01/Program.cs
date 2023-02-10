// Показать натуральные числа от N до 1, N задано

void NaturalNums(int n)
{
    if (n == 1) Console.Write("");
    else NaturalNums(n - 1);
    Console.Write($"{n} ");
}

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (n > 0) NaturalNums(n);
else Console.WriteLine("Ошибка. Натуральным является число больше нуля!");