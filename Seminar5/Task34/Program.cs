// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


 int[] GetArr (int arrSize, int leftRest, int rightRest)
 {  
    int[] arr = new int[arrSize];
    Random rand = new Random(); 
    for (int i=0; i<arrSize; i++)
    {
        arr[i]=Convert.ToInt32(rand.Next(leftRest,rightRest+1));
    }
    return arr; 
 }  

int CountEven (int[] arr)
{
int Result=0;
 for (int i=0; i < arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            Result++;
        }
    }
    return Result;
}

int[] resultArr = GetArr(8, 100, 999);
Console.WriteLine(string.Join(", ", resultArr));
Console.WriteLine($"Количество чётных чисел в массиве - {CountEven(resultArr)}");

