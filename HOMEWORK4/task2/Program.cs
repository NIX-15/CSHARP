Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine()!);
int numsum(int num)
{
    int result = 0;
    for(;;)
    {
        if(Math.Abs(num)>9)
        {
            result+=num%10;
            num/=10;
        }
        else break;
    }
    result+=num;
    return result;
}
Console.WriteLine($"The sum of the digits of {number}->{Math.Abs(numsum(number))}");