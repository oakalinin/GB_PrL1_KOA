// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем.

void inputVariables ()
{  
    int[] arr = new int[8];
    for (int i=0; i<8; i++)
    {
        Console.Write($"Введите элемент {i+1} - ");
        arr[i]=Convert.ToInt32(Console.ReadLine());
    }
 Console.Write("Массив - [");
 for (int i=0; i<8; i++)
    {
        if (i>0)
        {   
            Console.Write($"\t{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.WriteLine("]");
}

inputVariables();