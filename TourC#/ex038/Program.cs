// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] FillArrayRandom(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 100);
    }
    return array;
}

void PrintArrayEx2(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}]");
    double dif = 0;
    double max = array[0];
    double min = array[1];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    dif = max - min;
    Console.WriteLine($" -> {dif}");
}

int size = 4;
double[] array = FillArrayRandom(size);
PrintArrayEx2(array);