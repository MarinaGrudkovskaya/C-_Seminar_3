﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write("квадратов чисел от 1 до "+ number + " -> " );
while (count<= number)
{
   int number1 = count*count;
   Console.Write(number1 + ", ");
   count++;
}