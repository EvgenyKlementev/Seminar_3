
// Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

if (number<=0) Console.WriteLine("Вы ввели неправильное число!");

while (i <= number) 
{
    Console.Write(i*i+ ";");
i++;
}