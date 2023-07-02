
double a_b_distance(double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2)+Math.Pow(za-zb,2));
}
Console.WriteLine("Enter coordinates of point A(Xa,Ya,Za): ");
double Xa = double.Parse(Console.ReadLine()!);
double Ya = double.Parse(Console.ReadLine()!);
double Za = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinates of point B(Xb,Yb,Zb): ");
double Xb = double.Parse(Console.ReadLine()!);
double Yb = double.Parse(Console.ReadLine()!);
double Zb = double.Parse(Console.ReadLine()!);
Console.WriteLine($"The distance between A ({Xa},{Ya},{Za}) and B ({Ya},{Yb},{Zb}) is {Math.Round(a_b_distance(Xa,Xb,Ya,Yb,Za,Zb), 4)}");