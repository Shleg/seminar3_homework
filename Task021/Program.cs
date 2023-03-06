// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки А: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zB = int.Parse(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(xB -xA, 2) 
+ Math.Pow(yB -yA, 2) + Math.Pow(zB -zA, 2)), 2);

Console.WriteLine($"A ({xA},{yA},{zA}); B ({xB},{yB},{zB}), -> {distance}");