int[,] matrix = new int[new Random().Next(1, 8), new Random().Next(1, 8)];
void matfill()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-99, 100);
    }
}
int[] datalist(int[,] mat)
{
    Console.WriteLine();
    int[] arrData = new int[1];
    arrData[0] = mat[0, 0];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            int t = 0;
            while (true)
            {
                if (mat[i, j] == arrData[t])
                {
                    if (t == 0)
                        break;
                    //Console.WriteLine($"Number {mat[i, j]} has already added to the array!");
                    break;
                }
                if (mat[i, j] != arrData[t] && t == arrData.Length - 1)
                {
                    Array.Resize(ref arrData, arrData.Length + 1);
                    arrData[arrData.Length - 1] = mat[i, j];
                    break;
                }
                t++;
            }
        }
    }
    return arrData;
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
int[,] resultTable(int[,] mat, int[] arr)
{
    int[,] result = new int[arr.Length, 2];
    for (int i = 0; i < arr.Length; i++)
        result[i, 0] = arr[i];
    Console.WriteLine();
    for (int t = 0; t < result.GetLength(0); t++)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] == result[t, 0])
                    result[t, 1]++;
            }
        }
    }
    return result;
}
matfill();
displayMat(matrix);
displayMat(resultTable(matrix, datalist(matrix)));
