// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Random rand = new Random();
byte start_value = Convert.ToByte(rand.Next(1,8));


switch (start_value)
    {
    case <= 5:
         Console.WriteLine($"{start_value} -> нет");
         break;
    case >= 6:
         Console.WriteLine($"{start_value} -> да");
         break;
    }