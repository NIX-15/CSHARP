Console.Write("Enter the text: ");
string apozh = Console.ReadLine();
void reverse(string apo)
{
    for (int i = apo.Length - 1; i >=0; i--)
        Console.Write($"{apo[i]} ");
    Console.WriteLine();
}
reverse(apozh);
//Kortezhi zameni (arr[i],arr[i+1]) = (arr[0],arr[1])
//mozhno bez vremennih peremennih temp menyat pary