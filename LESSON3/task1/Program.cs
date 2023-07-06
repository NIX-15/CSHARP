// Multiplying table
void multi()
{
    for (int i = 1; i<11; i++)
    {
        for(int j = 1; j<11; j++)
        Console.Write($"{i}x{j}={i*j} ");
        Console.WriteLine();
    }
}
multi();
