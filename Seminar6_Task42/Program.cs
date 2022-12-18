// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int inputNumber = ReadData("Enter number: ");

PrintData("Result in bynary system: " + DegToBin(inputNumber));
PrintData("Result in bynary system: " + DecToBinNativ(inputNumber));
PrintData("Result in octal system: " + Convert.ToString(inputNumber, 8));           // используются встроенные методы
PrintData("Result in hexadecimal system: " + Convert.ToString(inputNumber, 16));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string DegToBin(int num)                // Метод, преобразующий десятичное число в двоичное
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

string DecToBinNativ(int num)           // Встроенный метод, преобразующий десятичное число в двоичное
{
    return Convert.ToString(num, 2);
}