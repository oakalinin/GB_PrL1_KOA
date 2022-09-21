// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите положительное целое число: ");
string start_value = Console.ReadLine();

switch (start_value)
    {
    case < 3:
         Console.WriteLine($"Третьей цифры нет. Задано не трехзначное число: {start_value}.");
         break;
    case > 2:
         Console.WriteLine($"Третья цифра в числе - {start_value.Substring(2,1)} .");
         break;
    }
    