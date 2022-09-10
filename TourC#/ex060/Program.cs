// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] Create3DMatrix(int x, int y, int z, int minVal, int stroke)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(minVal, minVal + stroke) * new Random().Next(1, 3);
                minVal += stroke;
            }
        }
    }
    return matrix;
}

int arg1 = 20;
int arg2 = 3;
void LinePrint(int[,,] matrix, int i = 0)
{
    if (i < matrix.GetLength(0))
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k})");
            }
        }
        LinePrint(matrix, i + 1);
    }
}

LinePrint(Create3DMatrix(2, 2, 2, arg1, arg2));

