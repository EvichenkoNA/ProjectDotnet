// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Первый способ

Console.WriteLine("Введите число: ");       //Просим пользователя ввести данные
int number = int.Parse(Console.ReadLine() ?? "0");

if (number >= 100)                     //Делаем проверку, действительно ли число явяетя трехзначным
{
    char[] numberArray = number.ToString().ToCharArray();  
    Console.WriteLine(numberArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры в введенном числе нет");
} 


