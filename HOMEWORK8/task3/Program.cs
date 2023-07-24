int size = 4;
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];

void matfill(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
            mat[i, j] = new Random().Next(-9, 10);
    }
}
int[,] multiMat(int[,] matA, int[,] matB)
{
    int[,] matC = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int t = 0; t < size; t++)
                matC[i, j] += matA[i, t] * matB[t, j];
        }
    }
    return matC;
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
matfill(matrixA);
matfill(matrixB);
displayMat(matrixA);
Console.WriteLine("X");
displayMat(matrixB);
Console.WriteLine();
displayMat(multiMat(matrixA, matrixB));
