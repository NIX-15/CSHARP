/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

int numberM = -13;
int numberN = 47;
bool numCheck(int m, int n)//Возможно это и не нужно. Решил ввести проверку неравенства
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
    if (n == m - 1)
        return;
    else
        recurEven(m, n - 1);//Переделал тут. Теперь вижу как набирается стэк. И сам принцип вывода(LIFO)
    if (n % 2 == 0)
        Console.Write($"{n} ");
}
if (numCheck(numberM, numberN))
{
    Console.Write($"Even numbers between {numberM} and {numberN}: ");
    recurEven(numberM, numberN);
    Console.WriteLine();
}
