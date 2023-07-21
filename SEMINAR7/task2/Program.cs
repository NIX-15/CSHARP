int[,] fillMatrix()
{
    int dimension = new Random().Next(1, 11);
    int[,] mat = new int[dimension, dimension];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(-9, 10);
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return mat;
}
int diagsum(int[,] mat)
{
    int result = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
        result += mat[i, i];
    return result;
}
Console.WriteLine($"Total Sum = {diagsum(fillMatrix())}");