// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int inputVariables (string textInvitation)
{  
    Console.Write(textInvitation);
    return Convert.ToInt32(Console.ReadLine());
}

void handmadePow (int Val, int degree)
{
    int resultPow = 1;
    if (degree>0)
    {
        for (int i=1; i <= degree; i++)
        {
            resultPow = resultPow*Val;
        }
        Console.WriteLine($"Число A={Val} в степени B={degree} равно: {resultPow}");
    }
    else 
    {
        Console.WriteLine("Не правильно задано число B. Оно должно быть натуральное.");
    }
}

handmadePow(inputVariables("Ведите значение числа А: "), inputVariables("Ведите значение числа B больше нуля: "));