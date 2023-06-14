Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i >= -num && i <= num)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}
