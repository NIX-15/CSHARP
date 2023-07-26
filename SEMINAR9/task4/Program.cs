/*Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
int num = -3;
int digree = 3;

int recurDig(int n, int d)
{
    if (d == 1)
        return n;
    if (d == 0)
        return 1;
    return n * recurDig(n, d - 1);
}
Console.WriteLine($"{num}^{digree}={recurDig(num, digree)}");
