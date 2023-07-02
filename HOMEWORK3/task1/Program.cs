// Task 1. Palindrome or not?
int digits(int num)
{
    int dig = 1;
    while (Math.Abs(num) > 9)
    {
        num = num / 10;
        dig++;
    }
    return dig;
}
bool palindrome(int num, int dig)
{
    int temp = 1;
    for (int t = 0; t < dig - 1; t++) temp *= 10;//понадобится для получения первого знака.
    while (dig > 1)
    {
        if (num / temp == num % 10)
        {
            num = (num - temp * (num / temp)) / 10;
            dig -= 2;
            temp /= 100;
        }
        else
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"So..We have the number {number} with {digits(number)} number of digits.");
if (palindrome(number, digits(number)))
    Console.WriteLine("Yes! This number is palindrome!");
else
    Console.WriteLine("No! This number is not palindrome!");