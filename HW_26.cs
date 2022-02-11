// Возведите число А в натуральную степень B, используя цикл.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());

int result = 1;

for(int i = 1; i <= b; i++) {
   result = result*a;
}
Console.WriteLine(result);