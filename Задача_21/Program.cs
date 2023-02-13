
/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Задайте X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте Z1: ");
double Z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Задайте X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте Y2: ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Задайте Z2: ");
double Z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X1-X2),2)+Math.Pow((Y1-Y2),2)+Math.Pow((Z1-Z2),2));

Console.WriteLine(result);