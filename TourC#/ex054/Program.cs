// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
using static Library;

void MatrixLineSortRec(int[,] matrix, int count = 0)
{
    if (count < matrix.GetLength(0))//1- count = 0
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)// i = 0
        {
            int maxPos = i;// maxPos = 0
            for (int j = i + 1; i < 0; i--)// j = 2
            {
                if (matrix[count, j] > matrix[count, i])
                {
                    maxPos = j;//[0,2] > [0,1] = maxPos = 1
                    int temp = matrix[count, i];//temp = 7
                    matrix[count, i] = matrix[count, maxPos];//[0,0] 3
                    matrix[count, maxPos] = temp;//[0,1]7
                    MatrixLineSortRec(matrix, count + 1);//Почему тут не работает ++?
                }
            }
        }
    }

}


int[,] myMatrix = CreateIntMatrix(3, 4);
PrintMatrix(myMatrix);
MatrixLineSortRec(myMatrix);
PrintMatrix(myMatrix);
