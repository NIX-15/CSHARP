Console.Write("Input Your Number: ");
int num = int.Parse(Console.ReadLine()!);//Да, почему-то всегда выдаются предупреждения при методе parse.
if (num % 2 != 0)
    Console.WriteLine($"Your Number {num} is Odd!");
else
    Console.WriteLine($"Your Number {num} is Even!");