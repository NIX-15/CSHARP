Console.Write("Enter the number: ");
double indigree (double num, double dig)
{
    return Math.Pow(num,dig);
}
double number = double.Parse(Console.ReadLine()!);
Console.Write("Enter the digree: ");
double digree = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{number}^{digree} = {indigree(number,digree)}");