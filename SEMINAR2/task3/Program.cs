Random RND = new Random();
int num = RND.Next(1,1000);
//num=322;
if(num%7==0 && num%23==0)
Console.WriteLine($"The number {num} is divided by 7 and 23 without remainder.");
else
Console.WriteLine($"The Number {num} is not divided by 7 or 23.");