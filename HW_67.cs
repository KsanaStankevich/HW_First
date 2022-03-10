// Показать натуральные числа от N до 1, N задано.
// N = 5. -> "5, 4, 3, 2, 1"

void Func(int num1, int num2)
{
    Console.Write($"{num1} ");
    if (num2 < num1)
        Func(num1 - 1, num2);
    else
        Console.ReadKey();
}

Func(10, 1);
