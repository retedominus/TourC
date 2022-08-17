// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.

int[] FillArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray2(int[] array)
{
    int size = array.Length - 1;
    System.Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{array[i]},");
    }
    int j = array.Length - 1;
    System.Console.Write($"{array[j]}");
    Console.WriteLine("]");
}

int[] array = FillArrayRandom(8);
PrintArray2(array);
