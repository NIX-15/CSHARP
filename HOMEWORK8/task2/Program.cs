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
    //
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
