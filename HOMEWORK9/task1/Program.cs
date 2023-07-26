/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

int numberM = -5;
int numberN = 11;
if (numberM > numberN)
    Console.WriteLine("Invalid input! N must not be lower than M!");
else
{
    Console.Write($"Even numbers between {numberM} and {numberN}: ");
    Console.Write(recurEven(numberM, numberN));
}
int recurEven(int m, int n)
{
    if (m == n - 1 && n % 2 != 0 || m == n && n % 2 == 0)
        return m;
    else
    {
        if (m % 2 == 0)
            Console.Write($"{m} ");
        return recurEven(m + 1, n);
    }
}
