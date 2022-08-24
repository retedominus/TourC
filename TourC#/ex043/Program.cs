// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
void Cross(int b1, int k1, int b2, int k2)
{
    //формула x = (b2 - b1) / (k1 - k2);
    double B = b2 - b1;
    double K = k1 - k2;
    double x = B / K;
    double y = k2 * x + b2;

    System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
}

System.Console.WriteLine("Введите числa b1, k1, b2, k2 через Enter");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
Cross(b1, k1, b2, k2);