// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// int number = ReadData("Введите число: ");
// string outLine = LineBuilder(number, 1 );
// PrintData("", outLine);
// outLine = LineBuilder(number, 2 );
// PrintData("", outLine);


// // Метод вывода данных
// void PrintData( string msg, string res)
// {
//     Console.WriteLine(msg + res);
// }

// // Метод сборки строки
// string LineBuilder(int n, int pow)
// {
//     string line = string.Empty;
//     for (int i=1; i<n; i++)
//     {
//         line = line + Math.Pow (i, pow) + " ";
//     }
//     line = line + Math.Pow (n, pow);
//     return line;
// }

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int n = ReadData ("Введите число: ");

string line = LineBuilder(n);

Console.WriteLine(line);


// Метод читает данные от пользователя
int ReadData(string msg) 
{     
    Console.WriteLine(msg);    
    return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int n)
{
    string line = "";
    string line2 = "";
    for (int i=1;i<n;i++){
        line+=i+",";
        line2+=i*i+ ",";
    }
    line+= n;
    line2+= n*n;
    return line + "\n"+ line2;
}