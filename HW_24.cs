// Найти кубы чисел от 1 до N

Console.WriteLine("Введите кол-во чисел для вывода:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Число" + "\t");
for (int i = 1; i <= N; i++)
    Console.Write(i + "\t");
Console.WriteLine();

for (int i = 1; i <= N; i++)
    Console.Write(i * i * i + "\t");

Console.ReadLine();