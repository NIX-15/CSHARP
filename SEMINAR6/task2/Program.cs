// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine()!);


void rev(string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
        Console.Write(s[i]);
    Console.WriteLine();
}
string binary(int num)
{
    string binar = string.Empty;
    while (num > 1)
    {
        binar += Convert.ToString(num % 2);
        num /= 2;
    }
    binar += Convert.ToString(num);
    return binar;
}
rev(binary(number));