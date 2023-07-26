/*Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Использовать рекурсию.
453 -> 12 45 -> 9*/

int num = -99;

int recurSum(int n)
{
    if (Math.Abs(n) < 10)
        return n;

    return n % 10 + recurSum(n / 10);
}
Console.WriteLine($"Digits sum of {num} is {recurSum(num)}");
