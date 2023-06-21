/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты точки А: ");
int ax = Convert.ToInt32(Console.ReadLine()!);

int ay = Convert.ToInt32(Console.ReadLine()!);

int az = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B: ");
int bx = Convert.ToInt32(Console.ReadLine()!);

int by = Convert.ToInt32(Console.ReadLine()!);

int bz = Convert.ToInt32(Console.ReadLine()!);


double AB = Math.Sqrt(Math.Pow((bx-ax), 2) + Math.Pow((by-ay), 2) + Math.Pow((bz-az), 2));

Console.WriteLine($"Растояние между АВ в 3D пространстве = {AB:f2}");