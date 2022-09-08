// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов
using static Library;

int[] LineValueSum(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

int LineMinValue(int[] array)
{
    int minPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPos]) minPos = i;
    }
    return minPos + 1;
}



int[,] matrix = CreateIntMatrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine($"Наименьшая сумма элементов в {LineMinValue(LineValueSum(matrix))} строке");


