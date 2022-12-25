// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Универсальный метод генерации и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round(rand.Next(topBorder, downBorder + 1) + rand.NextDouble(), 2);
        }
    }
    return array2D;
}


// Метод печатает числа разными цветами (переводим из double в string)
void PrintColoredNumber(double num)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    string numberInString = num.ToString();                             // переводим число в строку
    for (int i = 0; i < numberInString.Length; i++)                     // печатаем строку посимвольно, меняя цвета
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(numberInString[i]);
        Console.ResetColor();
    }
}

void Print2DArrayColor(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            PrintColoredNumber(matrix[i, j]);         // печатаем каждый элемент массива через вспомогательный метод
            Console.Write("       ".Substring(matrix[i, j].ToString().Length));    // выравниваем пробелы;
        }
        Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
Console.WriteLine("Двумерный массив, заполненный случайными вещетвенными числами: ");
double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);