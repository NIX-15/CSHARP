void fillMatrix()
{
    int[,] mat = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(-9, 10);
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
fillMatrix();//in progress