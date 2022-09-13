// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int inputVariables (string textInvitation)
{  
    Console.Write(textInvitation);
    return Convert.ToInt32(Console.ReadLine());
}

void handmadeSumDigits (int Val)
{
int result_handmadeSumDigits = 0;
int _Val=Math.Abs(Val);

for (int i=1; i <= Convert.ToString(Val).Length; ++i)
    { 
        result_handmadeSumDigits = result_handmadeSumDigits+(_Val % 10);
        _Val=_Val / 10;
     }
    Console.WriteLine($"Сумма цифр в числе {Val} равна {result_handmadeSumDigits}");
}

handmadeSumDigits(inputVariables("Ведите число: "));