// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[10];
double max = 0;
double dif = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.WriteLine(array[i]);
}
double min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}

Console.WriteLine();
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница максимального и минимального: " + (max - min));
