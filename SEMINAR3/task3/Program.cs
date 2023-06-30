double a_b_distance(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2));
}
Console.WriteLine("Enter coordinates of point A(Xa,Ya): ");
double Xa = double.Parse(Console.ReadLine()!);
double Ya = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter coordinates of point B(Xb,Yb): ");
double Xb = double.Parse(Console.ReadLine()!);
double Yb = double.Parse(Console.ReadLine()!);
Console.WriteLine($"The distance between A ({Xa},{Ya}) and B ({Ya},{Yb}) is {a_b_distance(Xa,Xb,Ya,Yb)}");