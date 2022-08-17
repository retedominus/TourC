public static class Library
{
    //Метод расчета расстояния между двумя точками
    public static double Distance(int[] A, int[] B)
    {
        int[] temp = new int[A.Length];
        double dist = 0;
        int sum = 0;
        if (A.Length != B.Length) System.Console.WriteLine("Введены неверные координаты одной из точек");
        else
        {
            for (int i = 0; i < A.Length; i++)
            {
                temp[i] = B[i] - A[i];

            }
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = temp[i] * temp[i];

                sum = sum + temp[i];
            }
        }
        return dist = Math.Sqrt(Convert.ToDouble(sum));
    }

    //Метод конвертации строки в массив
    public static int[] StringToArray(string str)
    {
        string[] temp = str.Split(",");
        int[] array = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            array[i] = Convert.ToInt32(temp[i]);
        }
        return array;
    }

    //Метод подсчета количества цифр в числе
    public static int NumOfDig(int arg)
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

    //Метод конвертации числа в массив
    public static int[] ConvertToArray(int arg)
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

    //Метод проверки числа на палиндром
    public static void PalCheck(int[] array)
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

    //Метод вывода в терминал массива
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    //Метод сложения матриц
    public static int[] SumMatrix(int[] m1, int[] m2)
    {
        int[] sum = new int[m1.Length];
        for (int j = 0; j < m1.Length; j++)
        {
            sum[j] = m1[j] + m2[j];
        }
        return sum;
    }

    ////Метод 
    public static string res(int[] x)
    {
        return string.Join(", ", x);
    }

    //Метод сравнения длинны массивов
    public static bool check(int[] x, int[] y)
    {
        return x.Length == y.Length;
    }

    //Замена слов в тексте
    public static string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }
        return result;
    }

    //Метод вывода кубов чисел от 1 до N
    public static int[] CubeTab(int arg)
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

    //Метод возведения числа в степень (без pow)
    public static double Degree(int arg1, int arg2)
    {
        double result = Convert.ToDouble(arg1);
        for (int count = 1; count < arg2; count++)
        {
            result = result * arg1;
        }
        return result;
    }


}