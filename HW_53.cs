// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

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

int find = 2;
int z = 0, x = 0;
bool f = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (find == array[i, j]) { z = i; x = j; f = true; };
    }
}

if (f)
    Console.WriteLine($"Число найдено. Строка {z+1} Столбец {x+1}");
else
    Console.WriteLine("Число не найдено");