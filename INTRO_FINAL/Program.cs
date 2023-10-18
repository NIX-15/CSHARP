string[] arrinit()
{
    Console.Write("Input the number L(Array Lenght): ");
    int L = int.Parse(Console.ReadLine()!);
    while (L < 1)
    {
        Console.Write("Error! Wrong Input! Input L again: ");
        L = int.Parse(Console.ReadLine()!);
    }
    string[] arrstr = new string[L];
    for (int i = 0; i < arrstr.Length; i++)
    {
        Console.Write($"Enter the value of the element {i + 1}: ");
        arrstr[i] = Console.ReadLine()!;
    }
    return arrstr;
}
void displayArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
displayArr(arrinit());