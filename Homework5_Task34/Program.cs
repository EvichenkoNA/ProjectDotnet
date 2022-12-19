//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//*Пузырьковая сортировка


int[] array = GenArray(100,100,999);
PrintArray(array);
int result = CountEven(array);
Console.WriteLine();
PrintData("Количество четных элементов в массиве составляет: ", result);
int[] sortArray = BubbleSort(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив методом пузырька:");
PrintArray(sortArray);

//Метод генерирует массив
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

//Метод выводит данные пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод выводит сгенерированный массив
void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод считает количетво четных чисел
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //if (array[i] % 2 == 0)
        if (EvenTest(array[i])) count++;
    }
    return count;
}

//Метод определяет являетcя ли число четным
bool EvenTest (int n)
{
    bool even = false;
    if (n % 2 == 0) even = true;
    return even;
}


// Сортировка пузырьком
int []  BubbleSort(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        for (int j=0; j<arr.Length-1; j++)
        {
            if(arr[j]>arr[j+1])         // Если элемент больше следующего, делаем обмен значениями 
            {
                int temp=arr[j];        // Присваиваем временной переменной зачение элемента
                arr[j]=arr[j+1];        // Меньший элемент ставим в "освобожденную " ячейку
                arr[j+1]=temp;          // В позицию j+1 возвращаем элемент из временной переменной
            }
        }
    }
    return arr;
}


/* // Метод сортировки пузырьком. 
int[] BubbleSort(int[] arr)
{
    int temp=0;
    for (int i = 0; i < arr.Length; i++)
    {
        bool checker = false;          // Переменная для проверки, был ли обмен значениями при проходе второго цикла
        for (int j = 0; j < arr.Length-i-1; j++)
        {
            if(arr[j]>arr[j+1])         // Если элемент больше следующего, делаем обмен значениями  
            {
                temp = arr[j];          // обмен
                arr[j] = arr[j+1];
                arr[j+1]=temp;
                checker = true;         // ставим значение, что был обмен
            }            
        }
        if(!checker) break;             // если не было обменов, то выходим из цикла For, сортировка окончена. 
    }
    return arr; */