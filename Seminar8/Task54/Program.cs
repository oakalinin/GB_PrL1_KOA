// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

int[,] GetSortArr(int[,] temp_arr)
{
    int tmpE;
    int indMin;
    for (int i=0; i<temp_arr.GetLength(0); i++)
        for (int j=0; j<temp_arr.GetLength(1); j++)
        {
            tmpE=temp_arr[i,j];
            indMin=j;
            for (int k=0; k<temp_arr.GetLength(1); k++)
            {
                if (tmpE<temp_arr[i,k])
                {
                    tmpE=temp_arr[i,k];
                    indMin=k;
                    temp_arr[i,k]=temp_arr[i,j];
                    temp_arr[i,j]=tmpE;
                }
            }     
        }
       
    return temp_arr;
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
        Console.WriteLine ("В итоге получается вот такой массив: ");
        arr=GetSortArr(arr);
        printArr (arr);
  }     
  else Console.Write("Неправильно задан размер массива.");