// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.

int NumOfChar(int arg)
{
    int div = 10;
    int count = 1;
    int value = arg / 10;
    while (value != 0)
    {
        value = arg / div;
        div = div * 10;
        if (value != 0) count++;
    }
    return count;
}

int[] ConvertToArray(int arg)
{
    int div = 10;
    int count = 0;
    int number = arg / div;
    int digit = arg % div;
    int[] array = new int[6];
    int[] temp = new int[array.Length];
    int j = temp.Length;
    while (count < temp.Length)
    {
        temp[count] = digit;
        digit = number % div;
        number = number / div;
        count++;
    }
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = temp[j - 1];
        j--;
    }
    return array;
}

void PalCheck(int[] array)
{
    int j = array.Length - 1;
    int x = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[j]) x++;
        j--;
    }
    if (x == array.Length / 2) System.Console.WriteLine("да");
    else System.Console.WriteLine("нет");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Console.Write("Введите шестизначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
int[] main = ConvertToArray(input);
if (main.Length != NumOfChar(input)) System.Console.WriteLine("Введено число недопустимой длинны");
else
{
    PrintArray(main);
    PalCheck(main);
}


