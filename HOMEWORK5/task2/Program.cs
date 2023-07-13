int dimension = new Random().Next(1, 21);
int[] array = new int[dimension];
void arrfill()
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}
int oddsum()
{
    int oddres = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)//отсчёт от 0 поэтому пишем как будто для чётных. Иначе можно (if((i%2)+1)!=0)
            oddres += array[i];
    }
    return oddres;
}
void displayArr()
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
arrfill();
displayArr();
Console.WriteLine($"Sum of odd elements is {oddsum()}");