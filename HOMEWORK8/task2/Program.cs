int[,] matrix = new int[new Random().Next(2, 7), new Random().Next(2, 7)];
void matfill(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
            mat[i, j] = new Random().Next(-99, 100);
    }
}
int[] sumCollect(int[,] mat)
{
    int[] sumTable = new int[mat.GetLength(0)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
            sumTable[i] += mat[i, j];
    }
    return sumTable;
}
void showLowestSum(int[,] mat, int[] sumtable)
{
    int imin = 0;
    for (int t = 0; t < sumtable.Length; t++)
    {
        if (sumtable[t] < sumtable[imin])
            imin = t;
    }
    Console.WriteLine(
        $"The row with the minimun sum of elements is #{imin + 1} ({sumtable[imin]}):"
    );
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write($"{mat[imin, j]} ");
    }
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
matfill(matrix);
displayMat(matrix);
Console.WriteLine();
showLowestSum(matrix, sumCollect(matrix));
Console.WriteLine();
