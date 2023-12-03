// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Ввидите число ");
int n = int.Parse(Console.ReadLine()!);
int number = new Random().Next(n);

Console.WriteLine(number);

int count = 1;
while (count<= number)
{
    int res = count*count*count;
    Console.Write(res + " ");
    count++;
}