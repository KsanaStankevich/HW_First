// Показать двумерный массив размером m×n, заполненный вещественными числами.

int m = new Random().Next(0, 10);
int n = new Random().Next(0, 10);
double[,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
