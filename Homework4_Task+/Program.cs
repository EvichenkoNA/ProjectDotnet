// Напишите программу, которая способна случайным образом выбрать человека из введенного списка

string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string NameSelect(string str)
{
    string[] names = str.Split(", ");
    string name = names[new Random().Next(0, names.Length)];
    return name;
}

string str = ReadStringData("Введите список имен (с пробелом через запятую): ");
PrintData("" + NameSelect(str));