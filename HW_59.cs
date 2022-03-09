// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArr(array);
PrintArr(array);
Console.WriteLine();

int result = 0;
int i = 1;
int number = 1;
int a = 100000; // Для теста ввела рандомное большое число
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        result = result + array[x, y];
    }
    Console.WriteLine($"Сумма элементов по строке {i} равна {result}");

    if (result < a)
    {
        number = i;
        a = result;
    }
    result = 0;
    i++;
}
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {number}");