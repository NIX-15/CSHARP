int[,] matrix = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
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
        int max = mat[i, 0];
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int t = j + 1; t < mat.GetLength(1); t++)
            {
                if (mat[i, t] > max)
                (mat[i,j],mat[i,t])=(mat[i,t],mat[i,j]);
                    max = mat[i, j];
            }
            //mat[i, j] = max;
        }
    }
    return mat;//in progress
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
displayMat(matrix);
Console.WriteLine();
displayMat(rowsort(matrix));