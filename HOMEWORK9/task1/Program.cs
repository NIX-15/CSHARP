/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

int numberM = -19;
int numberN = 32;
bool numCheck(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine("Invalid input! N must not be lower than M!");
        return false;
    }
    return true;
}
void recurEven(int m, int n)
{
    if (m == n - 1 && n % 2 != 0 || m == n && n % 2 == 0)
        Console.WriteLine($"{m}");
    else
    {
        if (m % 2 == 0)
            Console.Write($"{m}, ");
        recurEven(m + 1, n);
    }
}
if (numCheck(numberM, numberN))
{
    Console.Write($"Even numbers between {numberM} and {numberN}: ");
    recurEven(numberM, numberN);
}
