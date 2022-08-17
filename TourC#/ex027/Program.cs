// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
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

int SumNumArray(int[] arg)
{
    int sum = 0; 
    for (int i = 0; i < arg.Length; i++)
    {
        sum = sum + arg[i];
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = ConvertToArray(number);
int sum = SumNumArray(array);
System.Console.WriteLine($"{number} -> {sum}");