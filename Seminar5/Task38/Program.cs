// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
 
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

// Метод считает разницу между максимальным и минимальным элементами массива.
int diffElements (int[] arr)
{
    int[] arrMaxMin = new int[2]; // max значение записывается в элемент с индексом 0, а min записывается в элемент с индексом 1  
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>arrMaxMin[0])
        {
            arrMaxMin[0]=arr[i];
        }
        else if (arr[i]<arrMaxMin[1])
        {
            arrMaxMin[1]=arr[i];
        }
    }    
    return arrMaxMin[0]-arrMaxMin[1];
}

Console.Write("Задайте размер исходного массива (должно быть больше 1): ");
int ArrSize = Convert.ToInt32(Console.ReadLine());

if   (ArrSize>1) 
{
    int[] resultArr = GetArr(ArrSize,-10,10);
    Console.WriteLine($"Исходный массив [{string.Join(", ", resultArr)}]");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diffElements(resultArr)}.");
}
else 
{
 Console.WriteLine("Задайте размер исходного массива еще раз (значение должно быть больше 1)!");
}