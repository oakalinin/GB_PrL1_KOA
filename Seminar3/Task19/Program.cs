// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string s="";
if (Number >= 10000 && Number < 100000)
{
    
    for (int i=Convert.ToString(Number).Length; i>0; --i)
    {     
        s=s+Convert.ToString(Number)[i-1];   
    } 
    
    if (Number==Convert.ToInt32(s))
    {
        Console.WriteLine("Это палиндром.");
        }
    else
    {
        Console.WriteLine("Это не палиндром.");
    } 
}
else
{
    Console.WriteLine("Введено не пятизначное число.");
}