// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/* int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива.");

int[] arr = GenArr(arrLen);

PrintData("Сгененрированный массив:",arr); */



// Метод считывает данные с консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// Метод извлекает из введенного диапозона мин и мах
int[] MinMax(string msg)
{
    Console.WriteLine(msg);
    int[] num = new int[2];
    string inputStr = Console.ReadLine()??"0";
    string[] inputNum = inputStr.Split(',');
    num[0] = int.Parse(inputNum[0]);
    num[1] = int.Parse(inputNum[1]);
    return num;
}
// Метод заполняет массив случайными числами из установленного диапозона
int[] RandomArray(int len, int[] ind)
{
    int[] array = new int[len];
    for(int i=0; i<len; i++)
    {
        array[i] = new Random().Next(ind[0],ind[1]+1);
    }
    return array;
}
// Метод выводит массив
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length-1;i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write(array[array.Length-1]+"]");
}
//Метод собирает и выводит полученный результат
void PrintResult(string line, int[] array)
{
    Console.WriteLine(line);
    PrintArray(array);
}

int len = ReadData("Введите длину желаемого массива: ");
int[] ind = MinMax("Введите диапозон для псевдослучайных чисел в формате: Min,Max");
int[] answer = RandomArray(len, ind);
PrintResult("Сгенерированный массив: ",answer);