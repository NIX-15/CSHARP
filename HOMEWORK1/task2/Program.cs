Console.Write("Input Number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Number C: ");
int numC = Convert.ToInt32(Console.ReadLine()); ;
int MAX = numA;
if (MAX < numB)
    MAX = numB;
if (MAX < numC)
    MAX = numC;
Console.WriteLine($"The greatest Number is: {MAX}");
//Console.WriteLine(MAX);