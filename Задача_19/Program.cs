/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число:");
string? str = Console.ReadLine();
int num = 0;

if (str.Length != 5) Console.WriteLine($"Число {str} не является пятизначным!");

else
  for (int i = 0; i < str.Length / 2; i++)
  {
  if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
  {
  Console.WriteLine($"Число {str} не является палиндромом");
  break;
  }
  else
 num = 1; 
 if (num == 1) Console.WriteLine($"Число {str} является палиндромом");
 }