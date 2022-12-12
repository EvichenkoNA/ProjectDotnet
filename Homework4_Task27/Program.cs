// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Метод считывает данные пользователя
string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// вывод результата
void PrintData(string res)
{
    Console.WriteLine(res);
}

// вспомогательный метод для преобразоваия входных данных в массив
int[] ConvertArray(string inputString)
{
    char[] numChar = inputString.ToCharArray();
    int[] digits = new int[numChar.Length];
    for (int i=0; i<numChar.Length; i++)
    {
        digits[i] = ((int)numChar[i])-48;
    }
    return digits;
}

// метод вычисляет сумму с помощью строки
double VariantString(string inputString)
{
    int[] digits = ConvertArray(inputString);
    double result = 0;
    for (int i=0; i < digits.Length; i++)
    {
        result = result + digits[i];
    }
    return result;
}

// метод вычисляет сумму используя цифры
double VariantDigits(string inputString)
{
    double result = 0;
    int inputNum = int.Parse(inputString);
    while (inputNum>0)
    {
        result = result + inputNum%10;
        inputNum = inputNum/10;
    }
    return result;
}



string inputNum = ReadStringData("Введите число: ");

DateTime t1 = DateTime.Now;
DateTime t2 = DateTime.Now;

double sumSymbols =  VariantString(inputNum);
double sumDigits = VariantDigits(inputNum);

PrintData("Метод 1 (через преобразование символов) - Сумма цифр числа равна: " + sumSymbols +". Скорость метода составила "+ (DateTime.Now-t1));
PrintData("Метод 2 (через остаток от деления)      - Сумма цифр числа равна: " + sumDigits +". Скорость метода составила "+ (DateTime.Now-t2));

if (t1>t2) Console.WriteLine("Быстрее оказался 1-ый метод.");
else Console.WriteLine("Быстрее оказался 2-ый метод.");