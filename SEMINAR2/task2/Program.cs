Random RND = new Random();
int A = RND.Next(1,1000);
int B = RND.Next(1,1000);
if(A%B==0)
Console.WriteLine($"The number {A} is divided by the number {B} without remainder");
else
Console.WriteLine($"Not multiple! The remainder of division {A}:{B} is {A%B}");