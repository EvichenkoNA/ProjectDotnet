// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}


// Метод находит среднее арифметическое элементов в каждом столбце 
double[] AvgElem(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avgArray[j] += array[i, j];
        }
        avgArray[j] = Math.Round(avgArray[j] / array.GetLength(0), 2);
    }
    return avgArray;
}


// Задает цвет ячейки.
// Принимает индексы, возвращает цвет.
ConsoleColor GetColorСell(int i, int j)
{
    ConsoleColor[] col = new ConsoleColor[]
    {
         ConsoleColor.Black,
         ConsoleColor.Blue,
         ConsoleColor.Cyan,
         ConsoleColor.DarkBlue,
         ConsoleColor.DarkCyan,
         ConsoleColor.DarkGray,
         ConsoleColor.DarkGreen,
         ConsoleColor.DarkMagenta,
         ConsoleColor.DarkRed,
         ConsoleColor.DarkYellow,
         ConsoleColor.Gray,
         ConsoleColor.Green,
         ConsoleColor.Magenta,
         ConsoleColor.Red,
         ConsoleColor.White,
         ConsoleColor.Yellow
    };

    int numCol = (j - i) % col.Length;
    if (numCol < 0)
        numCol = col.Length + numCol;
    return col[numCol];
}

// Печатает двумерный массив в цвете по диоганали.
void Print2DArrayDigonalColor(int[,] array, int bias = 0)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = GetColorСell(i + bias, j);
            Console.Write(" " + array[i, j] + "   ".Substring(array[i, j].ToString().Length));
            Console.ResetColor();
            //Часть кода из разбора
            System.Threading.Thread.Sleep(50);                                     //Пауза после выполнения действий внутри цикла J на 100мс
        }
        Console.WriteLine();
    }
}

// Часть кода из разбора на семинаре
// Считает среднее арифметическое по диоганали.
double[] AverageDioganal(int[,] array2D)
{
    double[] arrayAverage = new double[array2D.GetLength(0) + array2D.GetLength(1) - 1];
    int sum = 0;
    int iStart = array2D.GetLength(0) - 1;
    int iFinish = array2D.GetLength(0);
    int jStart = 0;
    int j = 0;
    int n = 0;

    for (int k = 0; k < array2D.GetLength(0) + array2D.GetLength(1) - 1; k++)
    {
        for (int i = iStart; i < iFinish; i++)
        {
            sum = sum + array2D[i, j];
            n++;
            j++;
        }

        iStart--;
        if (iStart < 0)
        {
            iStart = 0;
            jStart++;
        }
        if (j > array2D.GetLength(1) - 1)
            iFinish--;

        j = jStart;
        arrayAverage[k] = Math.Round((double)sum / n, 2);
        sum = 0;
        n = 0;
    }

    return arrayAverage;
}

// Печатает одномерный массив в цвете по последней строке массива.
void Print1DArrayColor(string message, double[] array, int row)
{
    int i;
    Console.WriteLine(message);
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.ForegroundColor = GetColorСell(row - 1, i);
        Console.Write(array[i] + " ");
        Console.ResetColor();
    }
    Console.ForegroundColor = GetColorСell(row - 1, i);
    Console.WriteLine(array[array.Length - 1]);
    Console.ResetColor();
}

int row = ReadData("Введите количество строк:");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов:");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 1, 100);                                // Генерируем массив размером (row, column) с диапазоном значений от 1 до 99
Print2DArrayDigonalColor(arr2D);                                                       // Выводим на печать получившийся массив    
Console.WriteLine();
Print1DArrayColor("Среднее арифметическое по столбцам: ", AvgElem(arr2D), row);                                                     // Печатаем массив со средними значениями в каждом столбце */
Console.WriteLine();
Print1DArrayColor("Среднее арифметическое по диогонали: ", AverageDioganal(arr2D), row);

// Перелив цветов из семинара
/* DateTime time = DateTime.Now; // Радуга диоганальная
int n = 0;
Console.Clear();
while (true)
{
    if ((DateTime.Now - time) > TimeSpan.FromMilliseconds(100))
    {
        Console.SetCursorPosition(0, 0);
        arr2D = Fill2DArray(row, column, 10, 100);
        Print2DArrayDigonalColor(arr2D, n);
        n++;
        time = DateTime.Now;
    }
} */

