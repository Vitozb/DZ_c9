﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElement(int n, int m)
{
  if (n == m) return n;
  else return SumElement(n + 1, m) + n;
}



System.Console.Write("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма элементов {SumElement(n, m)}");
