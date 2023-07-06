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
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int t = i; t < arr.Length; t++)
        {
            min = arr[i];
            if (arr[t] < min)
                min = arr[t];
            arr[i] = arr[t];
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

//in progress