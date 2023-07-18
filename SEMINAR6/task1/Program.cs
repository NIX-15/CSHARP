Console.WriteLine("Enter the lenghts of triangle sides!");
double[] sides = new double[3];
double fillArray(double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        while (true)
        {
            Console.Write($"Side {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine()!);
            Console.WriteLine();
            if (lencheck(arr[i]))
            {
                sum += arr[i];
                break;
            }
        }
    }
    return sum;
}
bool lencheck(double len)
{
    if (len > 0) return true;
    else
    {
        Console.WriteLine("Error! Length of the triangle side must be greater than 0!");
        return false;
    }
}
bool existTriangle(double[] tri)
{
    double sum = fillArray(tri);
    for (int i = 0; i < tri.Length; i++)
    {
        if (tri[i] >= sum - tri[i])
        {
            Console.WriteLine("This triangle is impossible!");
            return false;
        }

    }
    Console.WriteLine("This triangle is possible!");
    return true;
}
existTriangle(sides);