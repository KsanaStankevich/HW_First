// Найти третью цифру числа или сообщить, что её нет.

int a = new Random().Next(1, 99999);
Console.WriteLine(a);

if (a > 99)
{
    while (a > 999)
    {
        a = a/10;
    }Console.WriteLine(a%10);
}
else Console.WriteLine("Третьей цифры нет");
    
