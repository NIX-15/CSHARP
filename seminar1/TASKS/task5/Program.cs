Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
while (Math.Abs(num) < 100 || Math.Abs(num) > 999)
{
    Console.Write("Input Your Number Again: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Math.Abs(num%10));