// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number:");
int number = int.Parse(Console.ReadLine()!);
void fibonacci(int num)
{
    string fib = "01";
    int p0 = 0; int p1 = 1;
    for (int i = 2; i < num; i++)
    {
        int sum = p0 + p1;
        fib += Convert.ToString(sum);
        p0 = p1; p1 = sum;
    }
    Console.WriteLine(fib);
}
if (number > 0)
    fibonacci(number);