// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] GetFilArr(int n=5, int m=5)
{
    int[,] matrix = new int[n, m];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = m;

    for (int i = 0; i < matrix.Length; i++)
      {
        matrix[row, col] = i + 1;
        if (--visits == 0) 
        {
          visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
          int temp = dx;
          dx = -dy;
          dy = temp;
          dirChanges++;
        }
        col += dx;
        row += dy;
      }
 return matrix;
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

 printArr(GetFilArr());

