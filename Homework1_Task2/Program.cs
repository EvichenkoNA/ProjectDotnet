// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа: ");    //Просим пользователя ввести данные

string? inputLine1 = Console.ReadLine();     //Считываем данные с консоли
string? inputLine2 = Console.ReadLine();

if(inputLine1!=null&&inputLine2!=null)       //Проверяем, чтобы данные были не пустыми
{
   int inputNumber1 = int.Parse(inputLine1);       //Парсим введенные числа
   int inputNumber2 = int.Parse(inputLine2);

   if(inputNumber1>inputNumber2)             //Проверяем, больше ли первое число второго
   {
      Console.Write("max = ");         
      Console.WriteLine(inputNumber1);
   }
   else
   {
      if(inputNumber1<inputNumber2)          //Проверяем, больше ли второе число первого
      {
         Console.Write("max = ");
         Console.WriteLine(inputNumber2);
      }
      else                                   //Если оба условия не выполняются, значит числа равны.               
      {
         Console.WriteLine("Максимального среди чисел нет. Числа равны.");
      }
   }
}