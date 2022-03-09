// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
void Sort(int[,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int p = 0; p < arr.GetLength(1); p++)
        {
            for (int y = 0; y < arr.GetLength(1) - 1; y++)
            {
                if (arr[x, y] > arr[x, y + 1])
                {
                    int z = arr[x, y];
                    arr[x, y] = arr[x, y + 1];
                    arr[x, y + 1] = z;
                }
            }
        }
    }
}

int m = 4;
int n = 8;
int[,] array = new int[m, n];

FillArr(array);
PrintArr(array);
Console.WriteLine();
Sort(array);
PrintArr(array);
