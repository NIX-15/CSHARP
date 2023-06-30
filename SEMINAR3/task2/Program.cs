bool numcheck(int num)
{
    if(num<1 || num>4)
    {
        Console.WriteLine("Invalid Input!");
        return false;
    }
    else return true;
}
void quartnum(int num)
{
    switch (num)
    {
        case 1:
        Console.WriteLine("X_POS+, Y_POS+");
        break;
        case 2:
        Console.WriteLine("X_NEG-, Y_POS+");
        break;
        case 3:
        Console.WriteLine("X_NEG-, Y_NEG-");
        break;
        default:
        Console.WriteLine("X_POS+, Y_NEG-");
        break;
    }
}
Console.Write("Enter the number of Quarter: ");
int number = int.Parse(Console.ReadLine()!);
if(numcheck(number)) quartnum(number);