Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);
int summary(int s)
{

    int sum = 0;
    for (int i = 0; i < num + 1; i++)
        sum += i;
    return sum;
}
Console.WriteLine($"Summary:{summary(num)}");