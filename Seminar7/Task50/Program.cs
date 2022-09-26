// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] GetArr(int size_1 = 3, int size_2=4, int minValue=-10, int maxValue=10)
{
    int[,] temp_arr = new int[size_1,size_2];
    Random rand = new Random(); 
    for (int i = 0; i<size_1; i++)
     for (int j=0; j<size_2; j++)
     {
        temp_arr[i,j]=rand.Next(minValue, maxValue+1);
     }
     return temp_arr;
}

void printArr(int[,] temp_arr)
{
    for (int i = 0; i<temp_arr.GetLength(0); i++)
    {
        for (int j=0; j<temp_arr.GetLength(1); j++)
        {
            Console.Write($"{temp_arr[i,j]}\t");       
        }
        Console.WriteLine("");
    }
}

void findArr(int[,] temp_arr,int tmp_row, int tmp_col)
{
    if (tmp_row<temp_arr.GetLength(0) & tmp_col<temp_arr.GetLength(1))
    {
        Console.WriteLine($"Элемент массива: {temp_arr[tmp_row,tmp_col]}");
    }
    else
    {
        Console.WriteLine($"Неправильно заданы координаты элемента массива. Допустимые значения - [индекс строки - от 0 до {temp_arr.GetLength(0)-1}, индекс столбца - от 0 до {temp_arr.GetLength(1)-1}].");
    }

}

int row;
int col;
Console.Write("Введите число строк: ");
int.TryParse(Console.ReadLine(), out row);

Console.Write("Введите число столбцов: ");
int.TryParse(Console.ReadLine(), out col);
if (col>0 & row>0)
  {
        int[,] arr = GetArr(row, col);
        printArr (arr);

        Console.Write("Введите координату элемента массива - индекс строки: ");
        int.TryParse(Console.ReadLine(), out int findrow);

        Console.Write("Введите координату элемента массива - индекс столбца: ");
        int.TryParse(Console.ReadLine(), out int findcol);
        
        if (findrow>0 & findcol>0)
        {
            findArr(arr, findrow, findcol);
        }
        else Console.Write("Неправильно заданs координаты элемента массива.") ;

  }     
  else Console.Write("Неправильно задан размер массива.");
   