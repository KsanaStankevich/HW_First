//  Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30

int Func(int x, int y)
{
    int s = 0;
    if ((y - 1) == x) return s = y + x;
    else s = y + Func(x, y - 1);
    return (s);
}

Console.WriteLine(Func(1, 4));
