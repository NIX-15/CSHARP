Console.WriteLine("Enter the point coordinates (X and Y):");
string pointquater (double x, double y)
{
    if(x>0 && y>0) return $"Point ({x},{y}) locates in 1st Quater!";
    if(x>0 && y<0) return $"Point ({x},{y}) locates in 4rd Quater!";
    if(x<0 && y>0) return $"Point ({x},{y}) locates in 2nd Quater!";
    if(x<0 && y<0) return $"Point ({x},{y}) locates in 3rd Quater!";
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
string res = pointquater(X,Y); 
Console.WriteLine(res);