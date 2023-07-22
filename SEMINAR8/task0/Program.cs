int[,] matinit()
{
    int[,] matrix = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}
void rowswap(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < mat.GetLength(1); i++)
        (mat[0, i], mat[mat.GetLength(0)-1, i]) = (mat[mat.GetLength(0)-1, i], mat[0, i]);

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
rowswap(matinit());