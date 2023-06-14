// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input Two Numbers To Compare: ");
int number = Convert.ToInt32(Console.ReadLine());
int squad = Convert.ToInt32(Console.ReadLine());
if (squad == number * number || number == squad * squad)
{
    Console.WriteLine("Correct!");
    if (squad >= number)
    {
        Console.Write(squad);
        Console.Write(" is square of ");
        Console.WriteLine(number);
    }
    else
    {
        Console.Write(number);
        Console.Write(" is square of ");
        Console.WriteLine(squad);
    }
}
else
{
    Console.WriteLine("Error. Try again!");
}