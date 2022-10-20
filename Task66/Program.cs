/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(M < N)
{
    int temp = 0;
    int sum(int M, int N)
    {
    if (M == N + 1)
        {
        return 0;
        }
    sum(M + 1, N);
    temp += M;
        {
        return temp;
        }
    }
    Console.WriteLine($"Сумма чисел в промежутке {M} и {N}" + sum (M, N));
}
else 
{
    int temp = 0;
    int sum(int M, int N)
        {
            if (M == N - 1)
            {    
                return 0;
            }
            sum(M - 1, N);
            temp += M;
                {
                    return temp;
                }
        }
    Console.WriteLine($"Сумма чисел в промежутке {M} и {N}: " + sum (M, N));
}