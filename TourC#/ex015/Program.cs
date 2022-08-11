// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 7) | (num < 1))
{
    Console.WriteLine("нет такого дня недели");
}
else
{
    if ((num == 6) | (num == 7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}