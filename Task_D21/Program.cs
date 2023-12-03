// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string messege)
   {
    Console.WriteLine(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }

int x1 = Prompt("Введите координату x точки 1: ");
int y1 = Prompt("Введите координату y точки 1: ");
int z1 = Prompt("Введите координату z точки 1: ");
int x2 = Prompt("Введите координату x точки 2: ");
int y2 = Prompt("Введите координату y точки 2: ");
int z2 = Prompt("Введите координату z точки 2: ");

double lonng = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
lonng = Math.Round(lonng, 2);
Console.Write(lonng);