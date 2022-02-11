// Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.WriteLine("Введите кол-во чисел для вывода:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Число" + "\t");
for (int i = 2; i <= N; i=i+2)
    Console.Write(i + "\t");
Console.WriteLine();

for (int i = 2; i <= N; i=i+2)
    Console.Write(i * i * i + "\t");

Console.ReadLine();
