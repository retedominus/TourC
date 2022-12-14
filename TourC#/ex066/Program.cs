// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using static Library;
int[] CreateArray(int arg1, int arg2)
{
    int size = (arg2 - arg1) + 1;
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arg1;
        arg1 = arg1 + 1;
    }
    return array;
}

int SumArrayContents(int[] array, int sum = 0, int i = 0)
{
    if (i < array.Length)
    {
        sum = SumArrayContents(array, sum, i + 1) + array[i];
    }
    return sum;
}

int M = 4;
int N = 8;
int elemSum = SumArrayContents(CreateArray(M, N));
System.Console.WriteLine($"M = {M}; N = {N}.-> {elemSum}");
