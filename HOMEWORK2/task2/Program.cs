Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
thirdigit(num);
void thirdigit(int n)
{
    n = Math.Abs(n);
    if (n < 100)
        Console.WriteLine($"The Third Digit of {num} is Missing!");
    else
    {
        while (n / 100 > 9)
        {
            n = n / 10;
        }
        Console.WriteLine($"The Third Digit of {num} is {n % 10}");
    }
}