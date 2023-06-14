int[] array = new int[new Random().Next(3,10)];
void fillarray(int[] arr)
{
    int ind = 0;
    while(ind<arr.Length)
    {
        arr[ind] = new Random().Next(0,100);
        ind++;
    }
}
void displayArr(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    Console.Write($"{arr[i]} ");
}
int arrMax(int[] arr)
{
    int max = arr[0];
    for(int i=1; i<arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
    }
    return max;
}
fillarray(array);
displayArr(array);
Console.WriteLine($"Largest Element of Array is {arrMax(array)}");