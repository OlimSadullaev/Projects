var c=0;
 c = int.Parse(Console.ReadLine());
 Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
 Console.Write($"{c,3}");

 /*c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");*/
for(int i = 0; i < 6; i++)
{
    c = c % 31 + 1;
    Console.Write($"{c,4}");
}
