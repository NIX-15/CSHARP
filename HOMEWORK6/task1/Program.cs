Console.WriteLine("Enter the numbers:");
int poscount()
{
    int count = 0;
    while (true)
    {
        int num = int.Parse(Console.ReadLine()!);
        //Console.WriteLine(num);
        if (num > 0)
            count++;
        else if (num == 0)
            break;
    }
    return count;
}
Console.WriteLine($"Positive numbers = {poscount()}");