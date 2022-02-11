// Подсчитайте сумму цифр в числе.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
int i = 0;

while (a >= 1)
{
    sum = sum + a % 10;
    a = a / 10;
    i++;
}
Console.WriteLine(sum);
