// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задайте значения для двух чисел - a и b");
Console.Write("Задайте значения a: ");

int number_a= Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения b: ");
int number_b= Convert.ToInt32(Console.ReadLine());

if (number_a > number_b)
{
 Console.Write("Большее число a = ", number_a);
  Console.Write(number_a);
 Console.Write(", минимальное число b = ", number_b);
 Console.WriteLine(number_b);
}
else if  (number_b > number_a) 
{
 Console.Write("Большее число b = ", number_b);
 Console.Write(number_b);
 Console.Write(", минимальное число a = ");
 Console.WriteLine(number_a);
}
else if  (number_b == number_a) 
{
 Console.Write("Введеные числа равны");
}

