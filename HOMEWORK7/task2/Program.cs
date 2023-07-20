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
int elementRequest(int[,] mat)
{
    int row, col = 0;
    for (; ; )
    {
        Console.Write("Enter the row number of element: ");
        row = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the column number of element: ");
        col = int.Parse(Console.ReadLine()!);
        if (row > 0 && row < mat.GetLength(0)+1 && col > 0 && col < mat.GetLength(1)+1)
            break;
        Console.WriteLine("Error! Invalid input of row/column number or Element is not exist!");
    }
    return mat[row-1, col-1];
}
Console.WriteLine($"The value of the requested array element = {elementRequest(fillMatrix())}");