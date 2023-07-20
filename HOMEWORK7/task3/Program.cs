int[,] fillMatrix()
{
    int[,] mat = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(-999, 1000);
            Console.Write($"{mat[i, j]}  ");
        }
        Console.WriteLine();
    }
    return mat;
}
double[] avrsum(int[,] mat)
{
    double[] arresult = new double[mat.GetLength(1)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
            arresult[j] += mat[i, j];
    }
    for (int t = 0; t < arresult.Length; t++)
        arresult[t] /= mat.GetLength(0);
    return arresult;
}
void resultDisplay(double[] avg)
{
    Console.WriteLine("Average values for each column:");
    for (int i = 0; i < avg.Length; i++)
        Console.Write($"{Math.Round(avg[i],2)}  ");
    Console.WriteLine();
}
resultDisplay(avrsum(fillMatrix()));