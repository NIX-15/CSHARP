void squadrow()
{
    int num = int.Parse(Console.ReadLine()!);
    if (num == 0) Console.WriteLine("0 is 0 in any digree!");
    else
    {
        for (int i = 1; i <= Math.Abs(num); i++)
            Console.Write(Math.Pow(i, 2) + " ");
    }
}
Console.Write("Enter the number: ");
squadrow();