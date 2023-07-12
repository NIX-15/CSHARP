Console.Write("Enter the dimension of array: ");
int dimension = int.Parse(Console.ReadLine()!);
void fillarray(int dim)
{
    int evencount=0;
    if (dim < 1)
        Console.WriteLine("Error! Dimension of Array must be greater than 0!");
    else
    {
        double[] array = new double[dim];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
            if(array[i]%2==0)
            evencount++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Here is {evencount} even number(s)!");
    }
}
    fillarray(dimension);//in progress