// See https://aka.ms/new-console-template for more information
Console.Write("Input Your Number: ");
int num = int.Parse(Console.ReadLine());
if(num%2!=0)
Console.WriteLine($"Your Number {num} is Odd!");
else
Console.WriteLine($"Your Number {num} is Even!");