Console.Write("Input Your Number: ");
int num = 0;
while(true)
{
    num = int.Parse(Console.ReadLine());
    if(num>=1 && num<=7)
    break;
    else
    {
        Console.Write("Invalid number. Try Again: ");
    }
}
switch(num)
{
case 6:
case 7:
Console.WriteLine("Weekend Day!");
break;

default:
Console.WriteLine("Regular weekday...");
break;
}