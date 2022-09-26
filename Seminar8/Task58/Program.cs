// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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

int[,] multipArr( int [,] arr_1, int[,] arr_2)
{ 
    int[,] result = arr_1;
    for (int i=0; i<arr_1.GetLength(0); i++)
        for (int j=0; j<arr_1.GetLength(1); j++) 
        {
            result[i,j]=arr_1[i,j]*arr_2[i,j];
        }   
return result;

}



int row;
int col;
Console.Write("Введите число строк массивов: ");
int.TryParse(Console.ReadLine(), out row);

Console.Write("Введите число столбцов массивов: ");
int.TryParse(Console.ReadLine(), out col);
if (col>0 & row>0)
  {
        int[,] tmparr_1 = GetArr(row, col);
        int[,] tmparr_2 = GetArr(row, col);
        Console.WriteLine("Массив 1:");
        printArr(tmparr_1);
        Console.WriteLine("Массив 2:");
        printArr(tmparr_2);
        Console.WriteLine("Их произведение будет равно следующему массиву:");
        printArr(multipArr(tmparr_1, tmparr_2));
  }     
  else Console.Write("Неправильно задан размер массива.");





