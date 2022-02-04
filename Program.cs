// Удалить вторую цифру трёхзначного числа.

int a = new Random().Next(100, 999);
Console.WriteLine(a);

int b = (a / 100)*10;
int c = (a % 10);
int result = b+c;
Console.WriteLine(result);