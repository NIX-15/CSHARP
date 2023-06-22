Console.Write("Input Number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Number B: ");
int numB = Convert.ToInt32(Console.ReadLine()); ;
if (numA > numB)
    Console.WriteLine($"{numA} is greater than {numB}");
else if (numB > numA)
    Console.WriteLine($"{numB} is greater than {numA}");
else
    Console.WriteLine($"The Numbers {numA} and {numB} are equal!");
