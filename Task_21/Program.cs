/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int Ax, Ay, Az;
int Bx, By, Bz;
double dis;
Console.WriteLine("Введите координаты x, y, z первой точки:");
Console.Write("x: ");
Ax = int.Parse(Console.ReadLine());
Console.Write("y: ");
Ay = int.Parse(Console.ReadLine());
Console.Write("z: ");
Az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x, y, z второй точки:");
Console.Write("x: ");
Bx = int.Parse(Console.ReadLine());
Console.Write("y: ");
By = int.Parse(Console.ReadLine());
Console.Write("z: ");
Bz = int.Parse(Console.ReadLine());
dis = Math.Sqrt(Math.Pow(Ax-Bx, 2)+Math.Pow(Ay-By, 2)+Math.Pow(Az-Bz, 2));
Console.WriteLine($"Расстояния между точками A и B: {Math.Round(dis, 2)}");