int[] array = new int[new Random().Next(10, 20)];
void fillarray(int[] arr)
{
    int ind = 0;
    while (ind < arr.Length)
    {
        arr[ind] = new Random().Next(0, 100);
        ind++;
    }
}
void arrsort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int t = i; t < arr.Length; t++)
        {
            if (arr[t] < arr[i])
            {
                int min = arr[t];
                arr[t] = arr[i];
                arr[i] = min;
            }
        }
    }
}
void showarr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
fillarray(array);
showarr(array);
arrsort(array);
showarr(array);