// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
string messege = "Введите пятизначное число: ";
int Prompt(string messege)
  {
    Console.WriteLine(messege);
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
  }
int num = Prompt(messege);

int num1 = num/1000;
int num2 = (num%10)*10 + (num%100)/10;
Console.WriteLine(num1 + " " + num2);
if (num1 == num2)
{
    Console.Write( num + " -> да");
}
else
{
    Console.Write( num + " -> нет");
}

