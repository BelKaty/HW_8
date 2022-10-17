/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
int[] array = new int [arr.GetLength(0)];
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
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
        {
         sum += arr[i, j];
        }
        array[i] = sum;
}
int minLine = array[0];
int numberOfLine = 0;
for (int i = 1; i < arr.GetLength(0); i++)
{
    if (array[i] < minLine)
        {
        minLine = array[i];
        numberOfLine = i;
        }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {numberOfLine + 1}");
