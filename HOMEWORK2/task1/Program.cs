Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secdig(int n)
{
    while (true)
    {
        if (Math.Abs(n) < 100 || Math.Abs(n) > 999)
        {
            Console.WriteLine("The Number is not Three-Digit! Type Another Number!");
            n = Convert.ToInt32(Console.ReadLine());
        }
        else break;
    }
    return n;
}
num = secdig(num);
Console.WriteLine($"The Second Digit of Your Number {num} is {Math.Abs(num / 10 % 10)}");