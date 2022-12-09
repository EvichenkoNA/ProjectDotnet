// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
bool PolindromTest(int number)
{
    bool result = false;
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) result = true;
    return result;
}

//Метод выводит данные пользователю
void PrintData(string msg, bool result)
{
    if (result == true) Console.WriteLine(msg + "Да");
    else Console.WriteLine(msg + "Нет");
}

int number = ReadData("Введите 5-ти значное число:");
if (number > 9999 && number < 100000)
{
    bool result = PolindromTest(number);
    PrintData("Является ли введенное число полиндромом? - ", PolindromTest(number));
}
else Console.WriteLine("Вы ввели не 5-ти значное число");





