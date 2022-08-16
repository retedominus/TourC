//Напишите метод, который принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
int[] StringToArray(string str)
{
    string[] temp = str.Split(",");
    int[] array = new int[temp.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        array[i] = Convert.ToInt32(temp[i]);
    }
    return array;
}
double Distance(int[] A, int [] B)
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

System.Console.WriteLine("Введите координаты точки A через запятую");
string a = Console.ReadLine();
System.Console.WriteLine("Введите координаты точки B через запятую");
string b = Console.ReadLine();
int[] A = StringToArray(a);
int[] B = StringToArray(b);
System.Console.WriteLine($"A ({a}); B ({b}) -> {Distance(A, B)}");
