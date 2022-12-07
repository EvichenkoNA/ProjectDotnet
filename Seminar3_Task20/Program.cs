// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


// int X1 = ReadData("Введите координату Х1: ");
// int Y1 = ReadData("Введите координату Y1: ");
// int X2 = ReadData("Введите координату Х2: ");
// int Y2 = ReadData("Введите координату Y2: ");

// double result = DistanceBetweenPoints(X1, Y1, X2, Y2);

// PrintData("Расстояние между точками: ", result);


// //PrintData("Расстояние между точками: ", DistanceBetweenPoints(ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: ")));


// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод находит расстояние между точками на плоскости
// double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
// {
//     double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
//     return distance;
// } 

// //Метод выводит данные пользователю
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int xh = ReadData("Введите xh: ");
int xv = ReadData("Введите xv: ");
int yh = ReadData("Введите yh: ");
int yv = ReadData("Введите yv: ");

double CalculateLength(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return res;
}


void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}

PrintData("Расстояние между точками ", CalculateLength(xh, xv, yh, yv));