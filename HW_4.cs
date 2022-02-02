// Найти максимальное из трех чисел
int a = 165;
int b = 206;
int c = 621;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
