/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double getUserDoubDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    double UserData = double.Parse(Console.ReadLine()!);
    return UserData;
}
string PointCross(double b1,double k1,double b2,double k2)
{
    
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    string str = " Точка пересечения имеет координаты ("+x+";"+y+")";
    return str;
}

double b1 = getUserDoubDate("Введите коефициент B1");
double k1 = getUserDoubDate("Введите коефициент K1");
double b2 = getUserDoubDate("Введите коефициент B2");
double k2 = getUserDoubDate("Введите коефициент K2");
Console.WriteLine(PointCross(b1,k1,b2,k2));