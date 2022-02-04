// Показать вторую цифру трёхзначного числа.

int a = new Random().Next(100, 999);
Console.WriteLine(a);
int Function(int b)
{
    return (b % 100)/10;
}

Console.WriteLine(Function(a));