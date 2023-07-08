Console.Write("Enter the number:");
/*string number = Console.ReadLine()!;
int dignum(string d)
{
    return d.Length;
}
Console.WriteLine($"{number}->{dignum(number)}");*/
int[] array = new int[new Random().Next(10, 20)];
int dignum(int[] arr)
{
    return arr.Length;
}
Console.WriteLine($"Number of digits is {dignum(array)}");