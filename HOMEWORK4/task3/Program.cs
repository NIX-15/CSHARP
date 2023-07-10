Console.Write("Enter the dimension of array: ");
int dimension = int.Parse(Console.ReadLine()!);
void fillarray(int dim)
{
    if (dim < 1)
        Console.WriteLine("Error! Dimension of Array must be greater than 0!");
    else
    {
        double[] array = new double[dim];
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(-99, 100);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}
    fillarray(dimension);