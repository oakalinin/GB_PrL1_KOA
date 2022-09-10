// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А:");
Console.Write("  координаты точки А по оси x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("  координаты точки А по оси y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("  координаты точки А по оси z: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("  координаты точки B по оси x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("  координаты точки B по оси y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("  координаты точки B по оси z: ");
int Bz = Convert.ToInt32(Console.ReadLine());

if (Bx!=Ax && By!=Ay && Bz!=Az)
{
   Console.WriteLine($"Расстояние между заданными точками: {Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2)):f2}"); 
}
else 
{
    Console.WriteLine("Точки совпадают.");
}
