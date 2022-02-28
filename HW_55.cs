// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 4;
int n = 4;
int[,] array = new int[m, n];

FillArr(array);
PrintArr(array);
Console.WriteLine();

int result = 0;
int count = 0;
int i = 1;
for (int x = 0; x < array.GetLength(1); x++)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        result = result + array[y, x];
        count += 1;
    }
    Console.WriteLine($"Среднее арифметическое по столбцу {i} равно {result / count}");
    result = 0;
    count = 0;
    i++;

}
Console.WriteLine();