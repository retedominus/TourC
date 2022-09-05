// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
using static Library;

void MatrixLineSortRec(int[,] matrix, int count = 0)
{
    if (count < matrix.GetLength(0))
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int maxPos = i;
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[count, j] > matrix[count, maxPos]) maxPos = j;
                int temp = matrix[count, i];
                matrix[count, i] = matrix[count, maxPos];
                matrix[count, maxPos] = temp;
                MatrixLineSortRec(matrix, count + 1);//Почему тут не работает ++?
            }
        }
}


int[,] myMatrix = CreateIntMatrix(4, 4);
PrintMatrix(myMatrix);
MatrixLineSortRec(myMatrix);
PrintMatrix(myMatrix);
