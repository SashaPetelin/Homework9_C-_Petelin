Console.WriteLine("Для вычисления функции Аккермана необходимо 2 неотрицательных числа.");
Console.WriteLine();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Значение функции: ");
Console.WriteLine(Akkerman(n,m));


int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}