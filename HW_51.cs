// Задать двумерный массив следующим правилом: Aₘₙ = m+n.

int m = new Random().Next(0, 10);
int n = new Random().Next(0, 10);
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}