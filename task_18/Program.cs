// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int GetQuarto()
  {
  Console.WriteLine("Введите номер четверти");
  int number = int.Parse(Console.ReadLine()!);
  return number;
  }
int quarto = GetQuarto();
if (quarto > 4 || quarto < 0)
{
   Console.WriteLine("Такой четверти нет"); 
}
if (quarto==1)
{
   Console.WriteLine("x > 0 и y > 0"); 
}
if (quarto==2)
{
   Console.WriteLine("x < 0 но y > 0"); 
}
if (quarto==3)
{
   Console.WriteLine("x < 0 так же y < 0"); 
}
if (quarto==4)
{
   Console.WriteLine("x > 0 но y < 0"); 
}