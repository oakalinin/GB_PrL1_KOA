// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] target()
{
    int size = 2;
    int[] b = new int[size];     
    int[] k = new int[size];    
    double[] result = new double[size+1];

    for (int i=0; i<size; i++)
    {
        Console.Write($"Задайте значение b{i+1}:");
        int.TryParse(Console.ReadLine(), out b[i]);
        Console.Write($"Задайте значение k{i+1}:");
        int.TryParse(Console.ReadLine(), out k[i]);
    }
    
    if (k[0]==k[1]) 
    {
        result[2] = 0;
    }
    else
    {
        result[0]=(double)(b[1]-b[0])/(k[0]-k[1]);              // расчет координаты X
        result[1]=(double)k[0]*(b[1]-b[0])/(k[0]-k[1])+b[0];    // расчет координаты Y
        result[2] = 1;
    }
return result;
}

double[] resultTarget = target();
switch (resultTarget[2]) 
    {
    case 0:
        Console.Write("Заданные прямые - параллельные.");
        break;
    case 1:
        Console.WriteLine($"Точка пересечения прямых: ({resultTarget[0]}, {resultTarget[1]}).");
        break;
    }
