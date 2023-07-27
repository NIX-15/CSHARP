/*Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от 
M до N с помощью рекурсии.
M = 1; N = 15 -> 120 M = 4; N = 8 -> 30*/

int numberM = 1;
int numberN = 15;


int recurSum(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    return n + recurSum(m, n - 1);
}
bool compareMN(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine("Error! N must be greater than or equal to M!");
        return false;
    }
    return true;
}
if (compareMN(numberM, numberN))
{
    Console.Write($"M = {numberM}; N = {numberN} -> ");
    Console.WriteLine(recurSum(numberM, numberN));
}