// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.


string text = ReadData("Введите символы с клавиатуры. В качестве разделителя используйте запятую (,):");
int[] numbers = StringToInt(text);
int count = CountPozitiveNum(numbers);
PrintData("Количество положительных чисел равно: " + count);

// Метод, считывающий данные, введенные пользователем
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, преобразуюший строку в массив, состоящий только из чисел
int[] StringToInt(string str)
{
    string[] symbols = str.Split(",");                         // Разбиваем строку по "пробелу"     
    int[] numbers = new int[symbols.Length];                   // Создаем новый массив, в который запишем числа
    for (int i = 0; i < symbols.Length; i++)
    {
       if (int.TryParse(symbols[i], out int result))            // Тест, является ли элемент массива числом. Если преобразование успешно, то преобразуем в число
       numbers[i] = int.Parse(symbols[i]);                      // Преобразуем строчный элемент в число    
    }
    return numbers;
}

// Метод, считающий количество положительных чисел введенных пользователем
int CountPozitiveNum(int[] num)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    return count;
}



//Вариант со* (инженерный подход). Рассмотрен на семинаре

/* using System.Text.RegularExpressions; //без явного указания сборки не работают регулярные выражения.

int taps = ReadData("Введите количество нажатий");

string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
Console.WriteLine(inputLine);

FindNumbersInString(inputLine,taps);

//Методы
int ReadData(string msg)//метод запрашивает и ситывает данные с консоли
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadLineData(string msg) //метод считывает нажатие клавиш на клавиатуре заданное количество раз и собирает данные в строку через запятую
{
Console.WriteLine(msg);
string line = "";
for (int i = 0; i < taps; i++)
{
    var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
    line = line + String.Format(key.KeyChar.ToString()) + ","; 
}
line = line.TrimEnd(','); //кусь последнюю запятую
return line;
}

void FindNumbersInString(string str, int count)//метод для поиска десятичных цифр в строке с помощью регулярных выражений
{
Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
int posNums = 0;
if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
{
    foreach (Match match in matches)
    {
        posNums = posNums + 1;
    }
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
}
else
{
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
}
} */