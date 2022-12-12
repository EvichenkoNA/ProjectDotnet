// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// *калькулятор

//метод для запроса чисел у пользователя
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}
//метод для запроса знака у пользователя
string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//метод ля вывода результата
void PrintData(string res)
{
    Console.WriteLine(res);
}

//калькулятор
double Сalculation(double number1, string mathOper, double number2)
{
    switch (mathOper)
    {
        case "+": return number1+number2;
        case "-": return number1-number2;
        case "*": return number1*number2;
        case "^": return Math.Pow(number1, number2);
        case "/": return number1/number2;
        
        default:
            throw new Exception("Введен некоректный математический оператор. Повторите ввод.");
    }
}


double number1 = ReadData("Введите первое число: ");
string mathOper = ReadStringData("Введите операцию: ");
double number2 = ReadData("Введите второе число: ");
double result = Сalculation(number1, mathOper, number2);
PrintData(number1 + " " + mathOper + " " + number2 + " = " + result);






