/*Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
double num = 3;
double digree = 3;

double recurDig(double n, double d)
{
    if (d == 1 || n == 0 && d != 0)
        return n;
    if (d == 0)
        return 1;
    if (d < 0)
        return (1 / n) * recurDig(n, d + 1);
    return n * recurDig(n, d - 1);
}
Console.WriteLine($"{num}^{digree}={recurDig(num, digree)}");
