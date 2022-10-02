// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int writeFunk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
         {
            return writeFunk(m - 1, 1);
         }
         else
         {
            return writeFunk(m - 1, writeFunk(m, n - 1));
         }
}
        
int m;
int n;
Console.Write("Задайте значение m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Задайте значение n: ");
int.TryParse(Console.ReadLine(), out n);

if (m>=0 & n>= 0)
{
    Console.Write($" m={m}, n={n}-> {writeFunk(m, n)}");
}
else Console.Write("Введите другие параметры функции.");