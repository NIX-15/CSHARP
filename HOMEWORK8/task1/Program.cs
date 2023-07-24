int[,] matrix = new int[new Random().Next(2, 7), new Random().Next(2, 7)];
void matfill()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-99, 100);
    }
}
int[,] rowsort(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int t = 0; t < mat.GetLength(1); t++)
            {
                if (mat[i, t] < mat[i, j])
                    (mat[i, j], mat[i, t]) = (mat[i, t], mat[i, j]);
            }
        }
    }
    return mat;
}

void displayMat(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}
matfill();
Console.WriteLine("MATRIX: ");
displayMat(matrix);
Console.WriteLine();
Console.WriteLine("SORTED MATRIX: ");
displayMat(rowsort(matrix));
