// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
string start_value = Convert.ToString(rand.Next(1,1000));

while ((start_value.Length != 3)==true)
 {
    start_value =  Convert.ToString(rand.Next(1,1000));
 }
Console.WriteLine($"Задано трехзначное число: {start_value}");
Console.WriteLine($"Вторая цифра в числе ({start_value}) - {start_value.Substring(1,1)} .");