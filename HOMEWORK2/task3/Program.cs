//Нужно было попробовать поработать с функциями типа string.
Console.Write("Input Your Number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(weekwork(num));
string weekwork(int n)
{
    string answer;
    while (n < 1 || n > 7)
    {
        Console.WriteLine("Invalid Input! Try Again!");
        n = Convert.ToInt32(Console.ReadLine());
    }
    switch (n)
    {
        case 6:
        case 7:
            answer = "Weekend Day!!!";
            break;
        default:
            answer = "Regular Workday..";
            break;
    }
    return answer;
}