﻿// Спирально заполнить двумерный массив:

class Program
{
    static void Main()
    {
        int N = 5;
        int M = 5;

        int[,] MM = new int[N, M];
        int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;
        int l = MM.Length;
        for (int i = 0; i < l; i++)
        {
            MM[row, col] = i + 1;

            if (--gran == 0)
            {
                gran = N * (dirChanges % 2) + M * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                int temp = dy;
                dy = -dx;
                dx = temp;
                dirChanges++;
            }
            col += dx;
            row += dy;
        }
        M = MM.GetLength(1);
        for (int k = 0; k < l; k++)
            Console.Write("{0}{1,3}", k % M == 0 ? "\n" : "", MM[k / M, k % M]);
        Console.ReadLine();
    }
}