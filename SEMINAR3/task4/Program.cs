void squadrow()
{
    int num = int.Parse(Console.ReadLine()!);
    for (int i = 1; i <= Math.Abs(num); i++)
        Console.Write(Math.Pow(i, 2) + " ");
}
Console.Write("Enter the number: ");
squadrow();