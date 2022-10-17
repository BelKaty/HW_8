/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
Console.WriteLine("Двумерный массив");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " \t");
    }
        Console.WriteLine();
}
Console.WriteLine($"Массив с сортировкой элементов в каждой сроке по убыванию" + " \t");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        {
        int temp = arr[i, j];
        for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > temp)
                    {
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                    temp = arr[i, j];
                    }
            }
        Console.Write($"{arr[i, j]} " + " \t");
        }
Console.WriteLine();
}