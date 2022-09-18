// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 
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
long CountElements (int[] arr)
{
    long Result=0;
    for (int i=0; i < arr.Length; i++)
    {
        if (i%2!=0)
        {
            Result = Result+arr[i];
        }
    }
    return Result;
}

Console.Write("Задайте размер исходного массива (должно быть больше 1): ");
int ArrSize = Convert.ToInt32(Console.ReadLine());

if (ArrSize>1) 
{
    int[] resultArr = GetArr(ArrSize,-10,10);
    Console.WriteLine($"Исходный массив [{string.Join(", ", resultArr)}]");
    Console.WriteLine($"Сумма элементов исходного массива, стоящих на нечётных позициях: {CountElements(resultArr)}.");
}
else 
{
     Console.WriteLine("Задайте размер исходного массива еще раз (значение должно быть больше 1)!");
}