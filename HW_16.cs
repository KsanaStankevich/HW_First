// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a = new Random().Next(1, 7);
Console.WriteLine(a);

if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной");
}
else Console.WriteLine("Не выходной");