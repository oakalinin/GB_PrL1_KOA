// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int tmpVal=0;

void sumPrint (int tmpM, int tmpN)
{     
    if (tmpM>tmpN)
    {
        return;
    }
    else
    {
        tmpVal=tmpVal+tmpM;
        sumPrint(tmpM+1, tmpN);
    }
}

int N;
int M;
Console.Write("Задайте значение M: ");
int.TryParse(Console.ReadLine(), out M);
Console.Write("Задайте значение N: ");
int.TryParse(Console.ReadLine(), out N);
sumPrint(M,N);
Console.Write($" M={M}, N={N}-> {tmpVal}");