// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//нельзя использовать pow

bool Natural(int arg)
{
    return arg > 0; 
}
double Degree(int arg1, int arg2)
{
    double result = Convert.ToDouble(arg1);
    for (int count = 1; count < arg2; count++)
    {
        result = result * arg1;
    }
    return result;
}

System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (Natural(B))
{
    double degree = Degree(A, B);
    System.Console.WriteLine($"{A}, {B} -> {degree}");
}
else System.Console.WriteLine("Степень должна быть натуральной.");