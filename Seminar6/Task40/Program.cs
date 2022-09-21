// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int[] GetArr ()
 { 
    int[] sizeSide = new int[3];

    for (int i=0; i<3; i++)
    {
        Console.Write($"Задайте длину стороны {i+1}:");
        int.TryParse(Console.ReadLine(), out sizeSide[i]);
    }
    
    return sizeSide;
 }


void validTriangle(int[] s)
{  
    if (s[0]>0 && s[1]>0 && s[2]>0)
    {
        if (s[0]<(s[1]+s[2]) && s[1]<(s[0]+s[2]) && s[2]<(s[0]+s[1]))
        {
             Console.WriteLine("Такой треугольник может быть.");
        }
        else 
        {
             Console.WriteLine($"Треугольник не может быть с такой длинной сторон ({string.Join(", ", s)}).");
        }
    }
    else
    {
      Console.WriteLine($"Треугольник не может быть с такой длинной сторон ({string.Join(", ", s)}).");
    }
}

validTriangle(GetArr());