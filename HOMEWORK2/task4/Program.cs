﻿// Задание №2 согласно концовке видео семинара
//Ввод random 3-х значного числа и вывод на экран без второго знака. 918 -> 98


//Мне показалось, что такой двухстрочный вариант оптимален.
//Простое и быстрое решение.
int num = new Random().Next(100,1000);
Console.WriteLine($"{num}->{num/100*10+num%10}");

/*Но если посчитаете это излишней халтурой, то вот другой вариант с методом.
int nosecondigit (int n)
{
    return n/100*10+n%10;
}
int num = new Random().Next(100,1000);
Console.WriteLine($"{num}->{nosecondigit(num)}");*/