// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задайте значения для трех чисел - a, b, с");

Console.Write("Задайте значения a: ");
int number_a= Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте значения b: ");
int number_b= Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте значения с: ");
int number_c= Convert.ToInt32(Console.ReadLine());

 Console.Write("Максимальное из веденных чисел - ");
 Console.WriteLine(Math.Max(Math.Max(number_a, number_b), number_c));