// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using static Library;
int[,] matrix = CreateIntMatrix(3, 4);
PrintMatrix(matrix);

double[] ArithmeticAvg(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] += matrix[i, j];
        }
        array[j] = Math.Round(array[j] / matrix.GetLength(0), 2);
    }
    return array;
}

System.Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(ArithmeticAvg(matrix));
