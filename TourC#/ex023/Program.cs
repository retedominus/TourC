// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] CubeTab(int arg)
{
    int num = 0;
    int[] array = new int[arg];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (num + 1) * (num + 1) * (num + 1);
        num++;
    }

    return array;
}

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Cub = CubeTab(N);
System.Console.Write($"{N} -> ");
PrintArray(Cub);