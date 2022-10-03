// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Задайте значение натурального числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetN(n);

void GetN (int n)
{
    if (n==0)
    {
        return;
    }
    Console.Write($"{n}  ");
    GetN(n-1);
}