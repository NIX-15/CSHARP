void fillMatrix()
{
    double[,] mat = new double[new Random().Next(1, 11), new Random().Next(1, 11)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                mat[i, j] = Math.Pow(new Random().NextDouble() * (10 + 9) - 9, 2);
                Console.Write($"!{Math.Round(mat[i, j], 2)}!  ");
            }
            else
            {
                mat[i, j] = new Random().Next(-9, 10);
                Console.Write($"{Math.Round(mat[i, j], 2)}  ");
            }
        }
        Console.WriteLine();
    }
}
fillMatrix();