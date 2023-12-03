// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// int GetKoordinat()
//   {
//     Console.Write("напишите координату: ");
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
//   }
// int x = GetKoordinat();
// int y = GetKoordinat();

int Prompt(string messege) //метод работы с пользователем. тут на вход принимаем строку, а возвращаем число
{
  Console.Write(messege);
  int number = int.Parse(Console.ReadLine()!);
  return number;
}
int x = Prompt("Введите координату X: ");  //Этот метод удобен тем, что можно менять сообщения, 
int y = Prompt("Введите координату Y: ");  //когда вызываешь разные переменные

// void PrintKoordinat(int nan1, int nam2)
//   {
//     Console.WriteLine("Координата x = "+ nan1 + ", " + "Координата y = " + nam2);
//   }
// PrintKoordinat(x, y);

// void GetRezult(int x, int y)
//   {
//    if (x>0 && y>0)
//    {
//        Console.Write("1 четверть");
//    }
//    if (x<0 && y>0)
//    {
//        Console.Write("2 четверть");
//    }
//    if (x<0 && y<0)
//    {
//        Console.Write("3 четверть");
//    }
//    if (x>0 && y<0)
//    {
//        Console.Write("4 четверть");
//    }
//   }
// GetRezult(x,y);

string GetRezult(int x, int y)  // возвращаемый тип метода, строковый тип, но принимает 2-а числа
  {
    string res = ""; //создали дополнительную переменную ( пустую строку)
   if (x>0 && y>0)
   {
       res = "1 четверть"; // вместо консоли теперь унас перезаписывается пересенная(наша строка)
   }
   else if (x<0 && y>0)  // можно оставить только "if", но тогда программа будет проходить по всему коду,
   {                     //  а с "else" закончит и перейдет в  "return"
      res = "2 четверть";
   }
   else if (x<0 && y<0)
   {
       res = "3 четверть";
   }
   else if (x>0 && y<0)
   {
       res = "4 четверть";
   }
   return res;
  }

string result = GetRezult(x, y); // можно выхывть метод через переменную, а потом
Console.WriteLine(result);            // распечатать на консоль    

Console.WriteLine(GetRezult(x, y));  // а можно сразу на консоль

if (x ==0 || y ==0)  //Это проверка, если введут 0
 {
  Console.WriteLine("Введены 000000!");
 }
 else
  {
    Console.WriteLine(GetRezult(x, y)); 
  }
