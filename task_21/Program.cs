// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int GetCoordinat() // метод работы с пользователем, запрашиваем координаты
   {
    Console.Write("Введите координату: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }

void PrintCoordinat(int x, int y)  //метот печати координат
    {
        Console.WriteLine();
        Console.WriteLine("Х-координатв точки = " + x);
        Console.WriteLine("Y-координатв точки = " + y);
    }

void GetDistance(int x1, int y1, int x2, int y2) //метод нахождения расстояния
    {
        
        double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2-y1)*(y2-y1)); // использую метод извлечения квадратного корня(встроенный)
        distance = Math.Round(distance, 3); //испольхзую метод округления (встроенный)
        Console.WriteLine();
        Console.Write("Расстояние между точками = " + distance);
    }

int ax = GetCoordinat();
int ay = GetCoordinat();
int bx = GetCoordinat();
int by = GetCoordinat();
PrintCoordinat(ax, ay);
PrintCoordinat(bx, by);
GetDistance(ax,ay,bx,by);