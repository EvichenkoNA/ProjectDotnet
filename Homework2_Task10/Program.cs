//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");       //Просим пользователя ввести данные
int number = int.Parse(Console.ReadLine() ?? "0");

if (number >= 100 && number < 1000)                     //Делаем проверку, действительно ли число явяетя трехзначным
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите попытку.");
}

