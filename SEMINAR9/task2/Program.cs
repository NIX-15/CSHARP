/*
Задача 2: Задайте значения M и N. Напишите программу, 
которая рекурсивно выведет все натуральные числа в промежутке от M до N.
 M = 1; N = 5 -> "1, 2, 3, 4, 5" 
 M = 4; N = 8 -> "4, 6, 7, 8"
*/
int recurNum(int n1, int n2)
{
    if (n1 == n2)
        return n1;
    Console.Write($"{n1}, ");
    return recurNum(n1 + 1, n2);
}
Console.Write("M-N: ");
Console.WriteLine(recurNum(-6, 7));