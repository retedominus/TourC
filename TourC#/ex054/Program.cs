// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
using static Library;

void MatrixLineSortRec(int[,] matrix, int row = 0)
{
    int temp = 0;
    if (row < matrix.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
            {
                if (matrix[row, j] > matrix[row, j - 1])
                {
                    temp = matrix[row, j];
                    matrix[row, j] = matrix[row, j - 1];
                    matrix[row, j - 1] = temp;
                }
            }
        }
        MatrixLineSortRec(matrix, row + 1);
    }
    
}


int[,] myMatrix = CreateIntMatrix(3, 4);
PrintMatrix(myMatrix);
MatrixLineSortRec(myMatrix);
PrintMatrix(myMatrix);
