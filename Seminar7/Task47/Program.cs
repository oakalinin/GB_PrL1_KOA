// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArr(int size_1 = 3, int size_2=4, int minValue=-10, int maxValue=10)
{
    double[,] temp_arr = new double[size_1,size_2];
    Random rand = new Random(); 
    for (int i = 0; i<size_1; i++)
     for (int j=0; j<size_2; j++)
     {
        temp_arr[i,j]=rand.NextDouble()*(maxValue - (minValue)) + (minValue);
     }
     return temp_arr;
}

void printArr(double[,] temp_arr)
{
    for (int i = 0; i<temp_arr.GetLength(0); i++)
    {
        for (int j=0; j<temp_arr.GetLength(1); j++)
        {
            Console.Write($"{temp_arr[i,j]:f1}\t");       
        }
        Console.WriteLine("");
    }
}

int row;
int col;
Console.Write("Введите число строк: ");
//int row = Convert.ToInt32(Console.ReadLine());
int.TryParse(Console.ReadLine(), out row);

Console.Write("Введите число столбцов: ");
//int col = Convert.ToInt32(Console.ReadLine());
int.TryParse(Console.ReadLine(), out col);
if (col>0 & row>0)
  {
        double[,] arr = GetArr(row, col);
        printArr (arr);
  }     
  else Console.Write("Неправильно задан размер массива.");
   

