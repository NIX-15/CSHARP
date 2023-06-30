Console.WriteLine("Enter the point coordinates (X and Y):");
string pointquarter (double x, double y)
{
    if(x>0 && y>0) return $"Point ({x},{y}) locates in 1st Quarter!";
    if(x>0 && y<0) return $"Point ({x},{y}) locates in 4rd Quarter!";
    if(x<0 && y>0) return $"Point ({x},{y}) locates in 2nd Quarter!";
    if(x<0 && y<0) return $"Point ({x},{y}) locates in 3rd Quarter!";
    else return "Error! The coordinates must not be zero!";
}
/*bool pointzero (int x, int y)
{
    if (x==0 || y==0)
    {
        Console.WriteLine($"Error! The coordinates must not be zero!");
        return false;
    }
    return true;
}*/
double X = double.Parse(Console.ReadLine()!);
double Y = double.Parse(Console.ReadLine()!);
string res = pointquarter(X,Y); 
Console.WriteLine(res);