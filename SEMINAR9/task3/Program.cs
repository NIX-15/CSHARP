/*Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Использовать рекурсию.
453 -> 12 45 -> 9*/

int num = 5;

int recurSum(int n) //in progress
{
    if (n < 10)
        return n;
    n = n % 10;
    return n + recurSum(n / 10);
}
Console.WriteLine($"Digits sum of {num} is {recurSum(num)}");
