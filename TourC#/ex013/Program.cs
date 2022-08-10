// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
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
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (NumOfChar(number) <= 2) 
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int div1 = Convert.ToInt32(Math.Pow(10, (NumOfChar(number) - 3)));
    Console.WriteLine((number / div1) % 10);
}

