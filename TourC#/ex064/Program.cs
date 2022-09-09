// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
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
void PrintArray(int[] array, int count = 0)//В методе испльзовал рекурсию, но она не обязательна
{
    if (count < array.Length)
    {
        System.Console.Write($"{array[count]} ");
        PrintArray(array, count + 1);
    }
    else Console.WriteLine();
}

int M = 1;
int N = 5;
System.Console.Write($"M = {M}; N = {N}.-> ");
PrintArray(CreateArray(M, N));

