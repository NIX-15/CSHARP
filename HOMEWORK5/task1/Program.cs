Console.Write("Enter the dimension of array: ");
int dimension = int.Parse(Console.ReadLine()!);
double[] array = new double[dimension];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
bool dimcheck(int dim)
{
    if (dim < 1)
    {
        Console.WriteLine("Error! Dimension of Array must be greater than 0!");
        return false;
    }
    else return true;
}
int arrayeven()
{
    int evencount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evencount++;
    }
    return evencount;
}
void displayArr()
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
if(dimcheck(dimension))
{
    displayArr();
    Console.WriteLine($"Here is {arrayeven()} even number(s)!");
}