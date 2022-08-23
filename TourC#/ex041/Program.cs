// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] StringToArray(string str)
{
    string[] temp = str.Split(" ");
    int[] array = new int[temp.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        array[i] = Convert.ToInt32(temp[i]);
    }
    return array;
}
int UpperZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
}




System.Console.WriteLine("Введите несколько чисел через пробел");
string input = Console.ReadLine();
int[] array = StringToArray(input);
int count = UpperZero(array);
PrintArray(array);
System.Console.WriteLine($" -> {count}");