// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[] UnicRnd(int sizeArr,int minValue=10, int maxValue=100)
{
    int tmpV;
    
    Random rand = new Random(); 
    tmpV = rand.Next(minValue, maxValue);
    
    string tmpStr = "'"+Convert.ToString(tmpV)+"'";

    int[] tmpArr = new int[sizeArr];
    
    tmpArr[0]= tmpV;
        
    for (int i=1; i<sizeArr; i++)
    {
        tmpV = rand.Next(minValue, maxValue);
        while (tmpStr.Contains("'"+Convert.ToString(tmpV)+"'"))
        { 
            tmpV = rand.Next(minValue, maxValue);
        }
        tmpStr = tmpStr+"'"+Convert.ToString(tmpV)+"'";
        tmpArr[i]= tmpV;
    }

     return tmpArr;
}

int[,,] GetArr(int size_1 = 2, int size_2=2, int size_3=2,int minValue=10, int maxValue=100)
{
    int l = 0;
    int[,,] temp_arr = new int[size_1,size_2,size_3];
    int[] tempValue = UnicRnd(size_1*size_2*size_3, minValue, maxValue);

    for (int i=0; i<size_1; i++)
     { 
        for (int j=0; j<size_2; j++)
            for (int k=0; k<size_3; k++)
            {
                temp_arr[i,j,k]=tempValue[l];
                l++;
            }
     }      
     
     return temp_arr;
}


void printArr(int[,,] temp_arr)
{
    for (int j=0; j<temp_arr.GetLength(1); j++)
     for (int i=0; i<temp_arr.GetLength(0); i++)
      {
        for (int k = 0; k<temp_arr.GetLength(2); k++)
        {
            Console.Write($"{temp_arr[i,j,k]}({i},{j},{k})\t");       
        }
        Console.WriteLine("");
    } 
}

int row;
int col;

Console.Write("Введите число строк массива: ");
int.TryParse(Console.ReadLine(), out row);

Console.Write("Введите число столбцов массива: ");
int.TryParse(Console.ReadLine(), out col);

if (col>0 & row>0)
  {
        int[,,] arr = GetArr(row, col, 2);
        printArr(arr);
  }     
  else Console.Write("Неправильно задан размер массива.");