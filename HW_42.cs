// Определить, сколько чисел больше 0 введено с клавиатуры.

string[] str = Console.ReadLine().Split(' ');
int numbers = 0;

for (int i = 0; i < str.Length; i++)
{
    double num = double.Parse(str[i]);
    // Console.WriteLine(num);
    if (num > 0) numbers++;
}
Console.WriteLine("Столько чисел больше нуля введено: "+ numbers);