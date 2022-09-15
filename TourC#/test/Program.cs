//метод проверки вводимого значения
int check_int_input(string message)
{
    bool input_data_not_ok = true; //введены некорректные данные
    int input = 0;                 //число для ввода
    string err_message = "";
    while (input_data_not_ok) //пока введены некорректные данные
    {
        Console.WriteLine($"{err_message}{message} :");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
            input_data_not_ok = false; //считаем что данные введены корректно
        }
        catch (SystemException)
        {
            input_data_not_ok = true; //пока введены некорректные данные
            err_message = "Неправильный ввод. ";
        }
    }
    return input;
}
