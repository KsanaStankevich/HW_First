// Даны два числа. Показать большее и меньшее число

int a = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);

int max = 0;
int min = 0;

if (b < a) 
{
    max = a; min = b;
}
else 
{
    max = b; min = a;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
