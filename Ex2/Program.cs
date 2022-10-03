// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение натурального числа М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение натурального числа N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) Console.WriteLine("М должен быть меньше N. Введите значения повторно!");

Console.Write("Сумма чисел от М до N равна ");
Console.WriteLine(GetSum(m));

int GetSum(int m)
{
    if (m <= n) 
    {
        return (m + GetSum(m+1));;
    }
    return 0;
}