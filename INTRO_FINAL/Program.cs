Console.Write("Input the number L(Array Lenght): ");
int L = int.Parse(Console.ReadLine()!);
while (L < 1) //Можно еще написать bool метод на проверку
{
    Console.Write("Error! Wrong Input! Input L again: ");
    L = int.Parse(Console.ReadLine()!);
}
string[] arrOld = new string[L]; //Объявление исходного массива
void fillArr(string[] arr)//Метод - наполение массива типа string
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter the value of the element {i + 1}: ");
        arr[i] = Console.ReadLine()!;
    }
}
string[] arrNew(string[] arrOld)//метод работающий с изначальным массивом, возвращает новый, по заданию
{
    int s = arrOld.Length;//кол-во строк нового массива. Можно не вводить, тогда в случае s=0, новый массив будет пустой
    for (int i = 0; i < arrOld.Length; i++)
    {
        if (arrOld[i].Length > 3)
            s--;
    }
    if (s == 0)
    {
        string[] arrNew = new string[1];
        //Console.WriteLine("There is not a single 'string' value in the original array whose length is at least 3");
        arrNew[0] = " No elements whose length is at least 3 ";
        return arrNew;
    }
    else
    {
        string[] arrNew = new string[s];//выявили размер нового массива строк. 
        s = 0;//использую ту же переменную счетчик для заполнения.
        for (int i = 0; i < arrOld.Length; i++)
        {
            if (arrOld[i].Length < 4)
            {
                arrNew[s] = arrOld[i];
                s++;
            }
        }
        return arrNew;
    }
}
void displayArr(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"\"{arr[i]}\" ");
    Console.Write("]");
    Console.WriteLine();
}
fillArr(arrOld);
displayArr(arrOld);
Console.WriteLine("Result: ");
displayArr(arrNew(arrOld));