// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
using static Library;
void SearchInMatrix(int[,] matrix, int row, int col)
{
    int result = 0;
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1)) 
        System.Console.WriteLine($"{result = matrix[row, col]}");
    else System.Console.WriteLine("такого числа в массиве нет");
    
}
int[,] matrix = new int[,]
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
};
PrintMatrix(matrix);

System.Console.WriteLine("Введите позицию искомого элемента через пробел");
string[] position = Console.ReadLine().Split(" ");
int row = Convert.ToInt32(position[0]);
int col = Convert.ToInt32(position[1]);

SearchInMatrix(matrix, row, col);




