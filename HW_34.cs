// Написать программу замену элементов массива на противоположные

int[] array = new int[] { 2, -13, 6, 11, -55, 91, 84, -28, 5 };
int count = 0;

int[] antarray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    antarray[i] = array[i] * (-1);
    Console.Write(antarray[i] + " ; ");
}
