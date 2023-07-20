void displaymat(double[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(mat[i, j],2)}  ");
        }
        Console.WriteLine(); Console.WriteLine();
    }
}
double[,] matinit()
{
    double[,] mat = new double[new Random().Next(1, 11), new Random().Next(1, 11)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().NextDouble()*(100+99)-99;
        }
    }
    return mat;
}
displaymat(matinit());