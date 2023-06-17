Console.Write("Input Your Number: ");
int num = int.Parse(Console.ReadLine());
int secdig(int n)
{
while(true)
{
if(Math.Abs(n)<100 || Math.Abs(n)>999)
{
    Console.WriteLine("The Number is not Three-Digit! Type Another Number!");
    n = int.Parse(Console.ReadLine());
}
else
break;
}
    return Math.Abs(n/10%10);
}
Console.WriteLine($"The Second Digit of Your Number  is {secdig(num)}");

//while(true)
//{
//    num = int.Parse(Console.ReadLine());
//    if(Math.Abs(num)>99 && Math.Abs(num)<1000)
//    {
//        break;
//    }
//    Console.WriteLine("The Number is not Three-Digit! Type Another Number!");
//}
//Console.WriteLine($"The Second Digit of Your Number {num} is {Math.Abs(num/10%10)}");