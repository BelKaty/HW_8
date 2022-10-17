/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Введите размер матрицы: ");
int sizeOfMatrix = Convert.ToInt32(Console.ReadLine());

int [,] GetMatrix(int M, int N) 
{
    int [,] matrix = new int [M, N];
    for (int i = 0; i < M; i++) 
    {
        for (int j = 0; j < N; j++) 
        {
           matrix[i, j] = new Random().Next(1, 10);
           Console.Write($"{matrix[i, j]}" + " \t");
        }
     Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
int[,] Matrix1 = GetMatrix(sizeOfMatrix,sizeOfMatrix);
int[,] Matrix2 = GetMatrix(sizeOfMatrix,sizeOfMatrix);
int[,] MatrixResult = new int [sizeOfMatrix,sizeOfMatrix];
Console.WriteLine($"Результат перемножения матриц: ");
for (int i = 0; i < sizeOfMatrix; i++)
{
    for (int j = 0; j < sizeOfMatrix; j++) 
    {
        int mult = 0;
        for (int k = 0; k < sizeOfMatrix; k++)
        {
            mult = mult + Matrix1[i, k] * Matrix2[k, j];
        }
        MatrixResult[i,j] = mult;
        Console.Write($"{MatrixResult[i, j]}" + " \t");
    }
    Console.WriteLine();
}