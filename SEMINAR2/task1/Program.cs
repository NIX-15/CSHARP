//Random rand = new Random(); Объявляем новый экземпляр класса Random под наименованием
// rand, но не инициализируем.
Random RND = new Random();
int num = RND.Next(0,100);
Console.WriteLine(num);
int a = num/10;
int b = num%10;
if(a>b) Console.WriteLine($"Number {a} is bigger than {b}");
else if(b>a) Console.WriteLine($"Number {b} is bigger than {a}");
else Console.WriteLine($"Number {b} is equal to {a}");