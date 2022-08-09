Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = (number % 100) / 10;
Console.WriteLine(secondNumber);