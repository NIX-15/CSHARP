int[,] matrix = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
void matfill()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}
int[,] transponate(int[,] mat)
{
    int[,] transe = new int[mat.GetLength(1), mat.GetLength(0)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            transe[j, i] = mat[i, j];
        }
    }
    return transe;
}
void displayMat(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i,j]} ");
        }
        Console.WriteLine();
    }
}
matfill();
displayMat(matrix);
Console.WriteLine();
displayMat(transponate(matrix));