// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using static Library;
int[,] MatrixMult(int[,] mtx1, int[,] mtx2)
{
    int[,] resMtx = new int[mtx1.GetLength(0), mtx1.GetLength(1)];
    for (int i = 0; i < mtx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtx1.GetLength(1); j++)
        {
            resMtx[i, j] = mtx1[i, 0] * mtx2[0, j] + mtx1[i, 1] * mtx2[1, j];
        }
    }
    return resMtx;
}

int[,] matrix1 = CreateIntMatrix(2, 2);
int[,] matrix2 = CreateIntMatrix(2, 2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
PrintMatrix(MatrixMult(matrix1, matrix2));
