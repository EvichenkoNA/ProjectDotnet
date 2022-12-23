// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//*Найдите площадь треугольника образованного пересечением 3 прямых

double b1 = ReadData("Введите число b1:");
double k1 = ReadData("Введите число k1:");
double b2 = ReadData("Введите число b2:");
double k2 = ReadData("Введите число k2:");
double b3 = ReadData("Введите число b3:");
double k3 = ReadData("Введите число k3:");

double[] point1 = IntersectionPoint(b1, k1, b2, k2);                                                                             // Находим пересечение первой и второй точки
double[] point2 = IntersectionPoint(b1, k1, b3, k3);                                                                             // Находим пересечение первой и третьей точки
double[] point3 = IntersectionPoint(b2, k2, b3, k3);                                                                             // Находим пересечение второй и третьей точки

double dist1 = DistPoints(point1, point2);                                                                                       // Вычисляем расстояние мужду первой и второй точкой
double dist2 = DistPoints(point1, point3);                                                                                       // Вычисляем расстояние между первой и третьей точкой
double dist3 = DistPoints(point2, point3);                                                                                       // Вычисляем расстояние между второй и третьей точкой

PrintData("Площадь треугольника, образованного пересечением 3 прямых, равна: " + AreaOfTriangle(dist1, dist2, dist3));           // Вычисляем площадь треугольника по трем сторонам

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод находит точку пересечения двух прямых
double[] IntersectionPoint(double a1, double b1, double a2, double b2)
{
    double[] point = new double[2];
    if (a1 != a2)
    {

        point[0] = (b2 - b1) / (a1 - a2);
        point[1] = a1 * point[0] + b1;
    }
    else
    {
        if (b1 != b2) Console.WriteLine("Прямые параллельны и не могут являться сторонами одного треугольника.");
        else Console.WriteLine("Прямые совпадают.");
    }
    return point;
}

//Метод находит расстояние между точками на плоскости
double DistPoints(double[] point1, double[] point2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2)), 2);
    return distance;
}

//Метод вычисляет площадь треугольника
double AreaOfTriangle(double dist1, double dist2, double dist3)
{
    double p = (dist1 + dist2 + dist3) / 2;                                                                 // Вычисляем полупериметр
    double area = Math.Round(Math.Sqrt(p * (p - dist1) * (p - dist2) * (p - dist3)), 2);                    // Вычисляем площадь треугольника
    return area;
}

