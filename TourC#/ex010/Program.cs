//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number / 100 == 0) | (number / 1000 != 0))
{
    Console.WriteLine("ВВЕДЕНО НЕВЕРНОЕ ЗНАЧЕНИЕ");
}
else 
{
    int secondNumber = (number % 100) / 10;
    Console.WriteLine(secondNumber);
}
