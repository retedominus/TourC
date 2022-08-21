//#1 - Здача аналогична предыдущей - Написать метод, который генерирует массив 0 и 1 заданного количества N
int[] FillArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray2(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

// System.Console.WriteLine("Введите длинну массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandom(N);
// PrintArray2(array);

//#2 - Написать метод, принимающий бинарное представление числа и возвращающее десятиченое представление числа

int[] StrToArray(string arg)
{
    string[] temp = arg.Split(" ");
    int[] array = new int[temp.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(temp[i]);
    }
    return array;
}

double BinToDecimal(int[] array)
{
    double number = 0;
    int temp = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        number = number + array[i] * Math.Pow(2, temp);
        temp--;
    }
    return number;
}

// System.Console.WriteLine("Введите число в двоичном представлении через пробел: ");
// string tempnum = System.Console.ReadLine();
// int[] binnum = StrToArray(tempnum);
// double decnum = BinToDecimal(binnum);

// System.Console.WriteLine($"{tempnum} -> {decnum}");

//#3 - Написать метод, принимающий десятичное представление и основание СС в которую нужно это число перевести
//2<= основание СС<= 9

int[] FromDecToAnother(int number, int arg)
{
    int[] res = new int[32];
    for (int i = res.Length - 1; i >= 0; i--)
    {
        res[i] = number - (number / arg) * arg;
        number = number / arg;
    }
    int index = 0;
    for (int i = 0; index == 0; i++)
    {
        if (res[i] > 0) index = i;
    }
    int newsize = res.Length - index;
    for (int i = 0; index < res.Length; i++)
    {
        res[i] = res[index];
        index++;
    }
    Array.Resize(ref res, newsize);
    return res;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите основание >= 2, но <= 9: ");
int arg = Convert.ToInt32(System.Console.ReadLine());
if (arg < 2 || arg > 9) System.Console.WriteLine("Вы ввели неверное основание");
else
{
    int[] res = FromDecToAnother(num, arg);
    System.Console.Write($"{num}, {arg} -> ");
    PrintArray2(res);
}