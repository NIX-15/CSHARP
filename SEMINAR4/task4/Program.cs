int[] array = new int[8];
void fillarray(int[] arr)
{
    int ind = 0;
    while (ind < arr.Length)
    {
        arr[ind] = new Random().Next(0, 2);
        ind++;
    }
}
void displayArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
fillarray(array);
displayArray(array);
//DZ Задача 1, никаких модулей.
//Задача 3 - Любой размер массива. 2 Функции.
//Везде for