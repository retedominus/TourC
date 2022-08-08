// Программа: Какое число большее, а какое меньшее
//В описании указано, что нужно вывести большее и меньшее число
//Сдалал как было в приведенном примере
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.WriteLine($"max = {max}");
