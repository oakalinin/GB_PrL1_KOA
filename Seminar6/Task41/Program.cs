// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int countDigit(string strStop = "stop" )
{
    int result=0;
    Console.WriteLine("Введите числа. Для прекращения ввода ведите стоп слово 'stop':");
    while (true)
    {
        string tmp_Digit = Console.ReadLine() ?? "";
        int.TryParse(tmp_Digit, out int tmp_value);
        
        if (tmp_Digit.ToLower() == strStop.ToLower())
        {
            break;
        }
        else if (tmp_value > 0 )
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine ($"Пользователь ввел следующее количество положительных чисел: {countDigit()}");