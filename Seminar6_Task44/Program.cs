// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int number = ReadData("Введите количество чисел:");
PrintData(FibNum(number));

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

//Числа Фибоначчи
string FibNum(double num)
{
    string outLine = "0 1";
    double first = 0;
    double last = 1;
    double buf = 0;
    for (double i = 2; i < num; i++)
    {
        outLine = outLine + " " + (first + last).ToString();
        buf = last;
        last = first + last;
        first = buf;
    }
    return outLine;
}