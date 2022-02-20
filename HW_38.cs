// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 9);
    Console.Write(array[i] + " ; ");
}

for (int j = 0; j < array.Length; j = j + 2)
{
    sum += array[j];
}

Console.WriteLine();
Console.WriteLine("Сумма элементов на нечетной позиции: " + sum);