﻿Console.WriteLine("Введите х1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите х2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine()!);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"расстояние между отрезками {length}");