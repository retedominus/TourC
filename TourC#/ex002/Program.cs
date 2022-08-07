// Программа: Какое число большее, а какое меньшее
//В описании указано, что нужно вывести большее и меньшее число
//Сдалал как было в приведенном примере
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.WriteLine($"max = {max}");
