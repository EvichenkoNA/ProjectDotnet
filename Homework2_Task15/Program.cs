// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Первый вариант

Console.WriteLine("Введите день недели числом от 1 до 7: ");       //Просим пользователя ввести данные
int number = int.Parse(Console.ReadLine() ?? "0");
Dictionary<int, string> WeekDay = new Dictionary<int, string>()        // Создаем словарь
{
    [1] = "рабочий день",
    [2] = "рабочий день",
    [3] = "рабочий день",
    [4] = "рабочий день",
    [5] = "рабочий день",
    [6] = "выходной",
    [7] = "выходной",
};
if (number >=1 && number <=7)                                          // При условии корреткного ввода числа выводим в консоль выходной день или нет
{
    Console.WriteLine(WeekDay[number]);
}
else 
{
    Console.WriteLine("Вы ввели не день недели, повторите ввод.");
}
 

// Второй вариант

/* Console.WriteLine("Введите день недели числом от 1 до 7: ");       //Просим пользователя ввести данные
int number = int.Parse(Console.ReadLine() ?? "0");

if (number >=1 && number <=7)                                          // При условии корреткного ввода числа выводим в консоль выходной день или нет
{
   if (number <=5)
    {
        Console.WriteLine("День является рабочим");                    // Выводим в консоль, что день рабочий, если введены числа в дипозоне 1-5
    }
    else
    {
        Console.WriteLine("День является выходным");                   // Выводим в консоль, что день выходной, если введенные числа 6 или 7
    }
}
else 
{
    Console.WriteLine("Вы ввели не день недели, повторите ввод.");
} */