// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5 
 
 // Метод задает массив
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

// Метод считает количество элементов массива, удовлетворяющих условию задачи
int CountElements (int[] arr, int leftRest, int rightRest)
{
    int Result=0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i]>=leftRest && arr[i]<=rightRest)
        {
            Result++;
        }
    }
    return Result;
}

int[] resultArr = GetArr(123, 0, 150);
Console.WriteLine($"Исходный массив [{string.Join(", ", resultArr)}]");
Console.WriteLine($"Количество элементов в исходном массиве, принадлежащих диапазону [10, 99] - {CountElements(resultArr, 10, 99)}");