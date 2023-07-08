Console.Write("Enter the number:");
int factorial(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        multi *= i;
    }
    return multi;
}
int number = int.Parse(Console.ReadLine()!);
if (number < 0)
    Console.WriteLine("Error! Negative Factorial!");
else
    Console.WriteLine($"{number}->{factorial(number)}");
/*string number = Console.ReadLine()!;
int dignum(string d)
{
    return d.Length;
}
Console.WriteLine($"{number}->{dignum(number)}");
int[] array = new int[new Random().Next(10, 20)];
int dignum(int[] arr)
{
    return arr.Length;
}
Console.WriteLine($"Number of digits is {dignum(array)}");*/