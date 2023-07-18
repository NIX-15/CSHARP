int dimension = new Random().Next(1, 21);
double[] array = new double[dimension];
void arrfill()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*(100-0)+0;
        Console.Write($"{Math.Round(array[i], 2)} ");
    }
    Console.WriteLine();
}
void minmax()
{
    double min=array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]>max)
        max=array[i];
        else if(array[i]<min)
        min = array[i];
    }
    Console.WriteLine($"Max.Element = {Math.Round(max, 2)}");
    Console.WriteLine($"Min.Element = {Math.Round(min, 2)}");
    Console.WriteLine($"{Math.Round(max, 2)}-{Math.Round(min, 2)} = {Math.Round(max, 2)-Math.Round(min, 2)}");
}
arrfill();
minmax();