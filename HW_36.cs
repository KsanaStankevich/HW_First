//  Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

int[] array = new int[10];
int sum_even = 0;
int sum_odd = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ; ");
    if (array[i]% 2 == 0 ) sum_even ++;
    else sum_odd ++;
}

Console.WriteLine();
Console.WriteLine("Количество четных элементов: " + sum_even);
Console.WriteLine("Количество нечетных элементов: " + sum_odd);
