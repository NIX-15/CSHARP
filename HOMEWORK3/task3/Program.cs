void digrow()
{
    int num = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the digree: ");
    int dig = int.Parse(Console.ReadLine()!);//пока нет проверки на ввод целочисленного значения степени
    if (num == 0) Console.WriteLine("0 is 0 in any digree!");
    else
    {
        int i = num / Math.Abs(num);//Что бы число в нечетной степени(^3, ^5 и.т.д) при работе с math.abs
        int k = 1;
        while (k != Math.Abs(num) + 1)
        {
            Console.Write(Math.Pow(i, dig) + " ");
            k++;
            i = num / Math.Abs(num) * k;
        }
    }
}
Console.Write("Enter the number: ");
digrow();