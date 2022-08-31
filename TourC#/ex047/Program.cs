// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using static Library;
double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
    return matrix;
}
double[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
