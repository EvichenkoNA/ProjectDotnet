/*
* Задача №16
* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
*/
// Console.WriteLine("является ли одно число квадратом другого ?");
// Console.Write("Введите первое число: ");

// int firstNumber;
// bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
// validate(isNumber);

// Console.Write("Введите второе число: ");
// int secondNumber;
// isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
// validate(isNumber);

// Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

// void validate(bool isNumber){
//     if (!isNumber){
//         Console.WriteLine("Вы ввели не число, выход");
//         Environment.Exit(0);
//     }
// }

// bool isSqrt(int a, int b){
//     return (a*a == b) || (b*b == a) ;
// }


void TestSQRT(int i, int j)
{
    bool result = (i/j==j);
    if(result==true)Console.WriteLine(" Число "+i+" является квадратом числа "+j);
    else Console.WriteLine(" Число "+i+" не является квадратом числа "+j);
}

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");
TestSQRT(number1,number2);
TestSQRT(number2,number1);