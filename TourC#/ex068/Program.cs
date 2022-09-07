// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 9 (в условиях задачи ошибка не 29)
int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Ackerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Ackerman(m - 1, Ackerman(m, n - 1));
    else return n + 1;
}

int m = 2;
int n = 3;
System.Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Ackerman(m, n)}");