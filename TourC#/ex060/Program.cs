// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int UnrepVal(int[,,] matrix, int minVal, int maxVal, int i, int j, int k)
{
    int count = 1;
    int number = new Random().Next(minVal, maxVal);
    for (i = matrix.GetLength(0) - 1; i >= 0; i--)
    {
        for (j = matrix.GetLength(1) - 1; j >= 0; j--)
        {
            for (k = matrix.GetLength(2) - 1; k >= 0; k--)
            {
                if (number == matrix[i, j, k]) 
                {
                    UnrepVal(matrix,minVal, maxVal, i, j, k);
                    count++;
                }
            }
        }
    }
    System.Console.WriteLine(count);
    return number;

}
int[,,] Create3DMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[i, j, k];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int number = UnrepVal(matrix, 10, 100, x, y, z);
                matrix[i, j, k] = number;
            }
        }
    }
    return matrix;
}

void LinePrint(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

int minVal = 10;
int maxVal = 100;
LinePrint(Create3DMatrix(4, 4, 4));

