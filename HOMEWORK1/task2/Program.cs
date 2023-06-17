Console.Write("Input Number A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Input Number B: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Input Number C: ");
int numC = int.Parse(Console.ReadLine());
int MAX = numA;
if(MAX<numB)
MAX=numB;
if(MAX<numC)
MAX=numC;
Console.WriteLine($"The Largest Number is: {MAX}");
//Console.WriteLine(MAX);