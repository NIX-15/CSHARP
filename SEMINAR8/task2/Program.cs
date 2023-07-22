int[,] matrix = new int[new Random().Next(1, 11), new Random().Next(1, 11)];
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
    //Array.Resize(ref arrData, arrData.Length + 1);
    //arrData[arrData.Length - 1] = mat[0, 1];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 1; j < mat.GetLength(1); j++)
        {
            for (int t = 0; t < mat.GetLength(0); t++)
            {
                for (int k = 0; k < mat.GetLength(1); k++)
                {
                    if (mat[i, j] == mat[t, k] && i != t && j != k)
                    Console.WriteLine($"Number {mat[t,k]} has already added to the array!");
                    break;
                }
            }
        
            /*for (int t = 0; t < arrData.Length; t++)
            {
                if (mat[i, j] == arrData[t])
                {
                    Console.WriteLine("Number has already added to the array!");
                    break;
                }
            }*/
            Array.Resize(ref arrData, arrData.Length + 1);
            arrData[arrData.Length - 1] = mat[i, j];
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
void displayArr(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
        Console.Write($"{arr[j]} ");
    Console.WriteLine();
}
matfill();
displayMat(matrix);
displayArr(datalist(matrix));//in progress