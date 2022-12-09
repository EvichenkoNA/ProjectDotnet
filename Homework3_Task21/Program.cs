// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/* int X1 = ReadData("Введите координату Х1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату Х2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");

double result = Distance(X1, Y1, Z1, X2, Y2, Z2);

PrintData("Расстояние между точками: ", result);


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));;
    return dist;
} 

//Метод выводит данные пользователю
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}
 */



string pointA = ReadData("Введите координаты первой точки (A) в формате: x1, y1, z1");
string pointB = ReadData("Введите координаты второй точки (B) в формате: x2, y2, z2");

double result = Distance(pointA, pointB);

PrintData("Расстояние между точками: ", result);


//Метод читает данные от пользователя
string ReadData(string msg)
{
    string s = string.Empty;
    Console.WriteLine(msg);
    return s=Console.ReadLine() ?? "0";
}

//Метод находит расстояние между точками на плоскости
double Distance(string pointA, string pointB)
{
    string[] coordA=pointA.Split(new char[] {','});
    string[] coordB=pointB.Split(new char[] {','});
    double dist = Math.Sqrt(Math.Pow(double.Parse(coordA[0]) - double.Parse(coordB[0]),2)+
                                Math.Pow(double.Parse(coordA[1]) - double.Parse(coordB[1]),2)+
                                Math.Pow(double.Parse(coordA[2]) - double.Parse(coordB[2]),2));
    return dist;
} 

//Метод выводит данные пользователю
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}
