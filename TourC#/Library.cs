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
    public static void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }


    //Метод печати многомерной матрицы
    public static void PrintDoubleMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
                if (j == (matrix.GetLength(1) - 1)) System.Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
                if (j == (matrix.GetLength(1) - 1)) System.Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    //Метод сложения элементов массива
    public static int SumArrayContents(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    //Метод тот-же но с рекурсией
    public static int SumArrayContents(int[] array, int sum = 0, int i = 0)
    {
        if (i < array.Length)
        {
            sum = SumArrayContents(array, sum, i + 1) + array[i];
        }
        return sum;
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

    //Метод перевода чисел из десятичного представления в любой
    public static int[] FromDecToAnother(int number, int arg)
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

    //Метод перевод бинарного в десятичное
    public static double BinToDecimal(int[] array)
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

    //Метод заполнения рандомного массива 
    public static int[] FillArrayRandom(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 2);
        }
        return array;
    }

    //Метод заполнения двумерной матрицы случайными вещественными числами
    public static double[,] CreateMatrixRealNum(int m, int n)
    {
        double[,] matrix = new double[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
            }
        }
        return matrix;

    }
    //Метод заполнения двумерной матрицы случайными целыми числами
    public static int[,] CreateIntMatrix(int m, int n)
    {
        int[,] matrix = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1, 10);
            }
        }
        return matrix;

    }

    //Метод определения среднего арифметического по столбцам матрицы
    public static double[] ArithmeticAvg(int[,] matrix)
    {
        double[] array = new double[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                array[j] += matrix[i, j];
            }
            array[j] = Math.Round(array[j] / matrix.GetLength(0), 2);
        }
        return array;
    }

    //Рекурсивная сортировка значений строк матрицы 
    public static void MatrixLineSortRec(int[,] matrix, int count = 0)
    {
        if (count < matrix.GetLength(0))
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int maxPos = i;
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[count, j] > matrix[count, maxPos]) maxPos = j;
                    int temp = matrix[count, i];
                    matrix[count, i] = matrix[count, maxPos];
                    matrix[count, maxPos] = temp;
                    MatrixLineSortRec(matrix, count + 1);//Почему тут не работает ++?
                }
            }
    }
    // Метод перемжножение прямоугольных матриц
    public static int[,] MatrixMult(int[,] mtx1, int[,] mtx2)
    {
        int[,] resMtx = new int[mtx1.GetLength(0), mtx1.GetLength(1)];
        for (int i = 0; i < mtx1.GetLength(0); i++)
        {
            for (int j = 0; j < mtx1.GetLength(1); j++)
            {
                resMtx[i, j] = mtx1[i, 0] * mtx2[0, j] + mtx1[i, 1] * mtx2[1, j];
            }
        }
        return resMtx;
    }

    //Метод расчета функции Аккермана
    public static int Ackerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if ((m > 0) && (n == 0)) return Ackerman(m - 1, 1);
        else if ((m > 0) && (n > 0)) return Ackerman(m - 1, Ackerman(m, n - 1));
        else return n + 1;
    }

}