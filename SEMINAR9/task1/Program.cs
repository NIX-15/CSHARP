/*Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/
//Method 1.
/*int recurNum(int num, int n)
{
    
    if (n == num) return num;
 Console.Write($"{n}, " );
    return recurNum(num, n+1);
}
Console.Write($"{recurNum(6,1)} ");*/

//Method 2
void recurNum(int num)
{
    if (num == 8)
    {
        Console.WriteLine($"{num}");
        return;
    }
    Console.Write($"{num}, ");
    recurNum(num + 1);
}
Console.Write($"N = 8 -> ");
recurNum(1);