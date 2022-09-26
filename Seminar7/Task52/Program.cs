// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArr(int size_1 = 3, int size_2=4, int minValue=-10, int maxValue=10)
{
    int[,] temp_arr = new int[size_1,size_2];
    Random rand = new Random(); 
    for (int i = 0; i<size_1; i++)
     for (int j=0; j<size_2; j++)
     {
        //int.TryParse(Console.ReadLine(), out temp_arr[i,j]); // Раскоментировать эту строку и закоментировать строку 16, если нужен ручной ввод значений массива
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

void AvgArr(int[,] temp_arr)
{
    double AvgRezult;

    for (int i = 0; i<temp_arr.GetLength(0); i++)
    {
        AvgRezult=0;
        for (int j=0; j<temp_arr.GetLength(1); j++)
        {
            AvgRezult=AvgRezult+temp_arr[i,j];       
        }
        AvgRezult = (double)AvgRezult/temp_arr.GetLength(1);
        Console.Write($"{AvgRezult:f2}\t");
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
        Console.Write("Среднее арифметическое каждого столбца: ");
        AvgArr(arr);
  }     
  else Console.Write("Неправильно задан размер массива.");
   