/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Точка пересечения двух прямых означает, что x1 = x2; y1 = y2. 
k1 * x + b1 = k2 * x + b2;
(k1 * x) - (k2 * x) = b2 - b1;
x * (k1 - k2) = b2 - b1;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1 */

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

void IntersectionPoint()
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    
    if ((k1 * point[0] + b1) == (k2 * point[0] + b2))
     {
        Console.Write("Точка пересечения двух прямых: ");
        Console.Write($"[{String.Join(", ", point)}]");
     }
    else
     {
    Console.WriteLine("Прямые не пересекаются.");
     }
}
IntersectionPoint();
