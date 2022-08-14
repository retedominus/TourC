// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// через массив
Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length <= 2)
{
     Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(number[2]);
}
