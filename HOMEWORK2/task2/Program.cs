Console.Write("Input Your Number: ");
int num = int.Parse(Console.ReadLine());
if(Math.Abs(num)<100)
Console.WriteLine("The Third Digit of Number is Missing!");
else
{
    while(Math.Abs(num)/100>9)
    {
        num = num/10;
    }
    Console.WriteLine($"The Third Digit of Number is {Math.Abs(num%10)}!!!"); 
}
