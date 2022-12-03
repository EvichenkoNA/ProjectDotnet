// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите три числа: ");    //Просим пользователя ввести данные

string? inputLine1 = Console.ReadLine();     //Считываем данные с консоли
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();

if(inputLine1!=null&&inputLine2!=null&&inputLine3!=null)       //Проверяем, чтобы данные были не пустыми
{
    int number1 = int.Parse(inputLine1);       //Парсим введенные числа
    int number2 = int.Parse(inputLine2);
    int number3 = int.Parse(inputLine3);
    
    if(number1>number2 && number1>number3)      //Проверяем, больше ли 1-е число двух других
    {
        Console.WriteLine("max = "+ number1);
    }
    else
    {
        if(number2>number1 && number2>number3)      //Проверяем, больше ли 2-е число двух других
        {
            Console.WriteLine("max = "+ number2);
        }
        else
        {
            Console.WriteLine("max = "+ number3);      //Если два предыдущих условия не удовлетворяются, то максимальным является 3-е число.
        }
    }
}