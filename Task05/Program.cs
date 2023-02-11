// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

// Если я правильно понял задачу, то нужно решение,
// в которм можно задавать последовательность с любым шагом
// Например, 1 2 3 4 ... N с шагом 1
// или 1 5 9 13 ... N c шагом 4
// и т.д
void PrintNums(int n1, int n2, int n)
{
    if (n == 0) Console.WriteLine($"");
    else
    {
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        PrintNums(n2, n2 * 2 - n1, n - 1);
    }
}

Console.WriteLine("Задайте первые два элемента последовательности");
Console.Write("1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("2: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Задайте, сколько N чисел надо показать: ");
int n = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    int temp = n1;
    n1 = n2;
    n2 = temp;
}

PrintNums(n1, n2, n);