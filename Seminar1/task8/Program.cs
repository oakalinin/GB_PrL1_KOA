// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Задайте значение числа (число должно быть > 0 : ");
int number_a= Convert.ToInt32(Console.ReadLine());
string result = "";
if (number_a > 0)
{
    for (int i = 1; i <= number_a; i++)
    {
        if (i % 2 == 0)
            {
               result = " " +result + Convert.ToString(i) + ", ";
            }
    }

    Console.Write("Все четные числа от 0 до ");
    Console.WriteLine(number_a);
    Console.WriteLine(result.Trim(new char[] { ' ', ',' }));
} 
else
{
    Console.Write("Введено число, не отвечающее заданному условию.");
}