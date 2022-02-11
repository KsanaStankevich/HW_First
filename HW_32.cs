﻿// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(col[position]+"\t");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);