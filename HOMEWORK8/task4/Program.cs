int[,] matrix = new int[new Random().Next(2, 7), new Random().Next(2, 7)];
void matfill(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
            mat[i, j] = new Random().Next(-99, 100);
    }
}
int[,] matrixReduction(int[,] mat)
{
    int[,] matred = new int[mat.GetLength(0) - 1, mat.GetLength(1) - 1];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] < mat[imin, jmin])
            {
                imin = i;
                jmin = j;
            }
        }
    }
    Console.WriteLine($"Min.Element = {mat[imin, jmin]}, row = {imin + 1}, column = {jmin + 1}");
    Console.WriteLine();
    int ii = 0;
    int jj = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (i == imin || j == jmin) { }
            else
            {
                if (ii == matred.GetLength(0) - 1 && jj == matred.GetLength(1) - 1)
                {
                    matred[ii, jj] = mat[i, j];
                    break;
                }
                else if (ii != matred.GetLength(0) - 1 && jj == matred.GetLength(1) - 1)
                {
                    matred[ii, jj] = mat[i, j];
                    ii++;
                    jj = 0;
                }
                else
                {
                    matred[ii, jj] = mat[i, j];
                    jj++;
                }
            }
        }
    }
    return matred;
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
displayMat(matrixReduction(matrix));