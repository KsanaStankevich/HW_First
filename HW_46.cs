// Написать программу масштабирования фигуры

double[] ArrayParseStringToInt(string[] coordinatesString) // Преобразование массива в int
{
    double[] coordinatesDouble = new double[coordinatesString.Length];
    for (int i = 0; i < coordinatesString.Length; i++)
    {
        coordinatesDouble[i] = double.Parse(coordinatesString[i]);
    }
    return coordinatesDouble;
}

void ScalingArray(double[] array, double k) // Масштабирование
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * k;
    }
}

void PrintNewCoordinates(double[] array) // Вывод массива
{
    for (int i = 0; i < array.Length; i += 2)
    {
        Console.Write($"({array[i]},{array[i + 1]}) ");
    }
    Console.WriteLine();
}

Console.Write("Введите координаты 4х точек: ");
string[] coordinates = Console.ReadLine().Replace("(", "").Replace(",", " ").Replace(")", "").Split(" ");
double[] coordinatesDouble = ArrayParseStringToInt(coordinates);
Console.Write("Введите коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine());
ScalingArray(coordinatesDouble, k);
PrintNewCoordinates(coordinatesDouble);