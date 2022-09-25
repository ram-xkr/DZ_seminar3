// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;

Clear();
Write("Введите координаты первой точки (X, Y, Z): ");
int ax = int.Parse(ReadLine()!);
int ay = int.Parse(ReadLine()!);
int az = int.Parse(ReadLine()!);
Write("Введите координаты второй точки (X, Y, Z): ");
int bx = int.Parse(ReadLine()!);
int by = int.Parse(ReadLine()!);
int bz = int.Parse(ReadLine()!);
double ab = Math.Sqrt(Math.Pow((bx-ax), 2) + Math.Pow((by-ay), 2) + Math.Pow((bz-az), 2));
WriteLine($"Расстояние между точками ровняется {ab:f2}");
