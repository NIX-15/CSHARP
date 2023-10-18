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
string[] newArr(string[] oldArr)
{
    int s = oldArr.Length;
    for (int i = 0; i < oldArr.Length; i++)
    {
        if (oldArr[i].Length > 3)
            s--;
    }
    if (s == 0)
    {
        string[] newArr = new string[1];
        //Console.WriteLine("There is not a single 'string' value in the original array whose length is at least 3");
        newArr[0] = "No elements whose length is at least 3";
        return newArr;
    }
    else
    {
        string[] newArr = new string[s];
        s = 0;
        for (int i = 0; i < oldArr.Length; i++)
        {
            if (oldArr[i].Length < 4)
            {
                newArr[s] = oldArr[i];
                s++;
            }
        }
        return newArr;
    }

}
void displayArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
//displayArr(arrinit());
displayArr(newArr(arrinit()));