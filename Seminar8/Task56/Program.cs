// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void minSumElement (int[,] tmp_arr)
{
    int tmpE;
    int indMin=0;
    int tmpMin=tmp_arr[0,0];
    for (int i=0; i<tmp_arr.GetLength(0); i++)
    {   tmpE=0;
        for (int j=0; j<tmp_arr.GetLength(1); j++)
        {
            tmpE=tmpE+tmp_arr[i,j];
        }
        if (tmpE<tmpMin)
        {
            tmpMin=tmpE;
            indMin=i;
        }
    }   
    Console.WriteLine ($"Номер строки с наименьшей суммой элементов: {indMin+1} строка.");
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
        printArr(arr);
        minSumElement(arr);
  }     
  else Console.Write("Неправильно задан размер массива.");