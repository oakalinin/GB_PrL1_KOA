// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void masPrint (int tmpN)
{     
    if (tmpN<=0)
    {
        return;
    }
    else
    {
        Console.Write($"{tmpN}\t");
        masPrint(tmpN-1);
    }
}

int N;
Console.Write("Задайте значение N: ");
int.TryParse(Console.ReadLine(), out N);
Console.Write($" N={N}-> ");
masPrint(N);