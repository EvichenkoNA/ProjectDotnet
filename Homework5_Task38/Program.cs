﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// *Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.

int number = ReadData("Введите количество элементов в массиве: ");                                          // Пользователь задает количество элементов в массиве
int minValue = ReadData("Введите нижнюю границу массива: ");                                 // Пользователь задает нижний диапазон числа в массиве
int maxValue = ReadData("Введите верхнюю границу массива: ");                                // Пользователь задает верхний диапазон числа в массиве
double[] array = GenArray(number, minValue, maxValue);                                                         // Генерируем массив с заданными параметрами
Console.WriteLine();  
PrintData("Исходный массив: ");
PrintArray(array);                                                                                          // Выводим массив на печать
Console.WriteLine();

//Переменные для нахождения максимального и минимального элемента массива.
double min = double.MaxValue;
double max = double.MinValue;
MinMax(array);

PrintData($"Минимально исло в массиве - {min}. Максимальное - {max}. Разница между ними составила = {max-min}");

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, генерирующий массив
double [] GenArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, (maxValue + 1)) + new Random().NextDouble();
    }
    return arr;
}

// Метод, который находит минимальный и максимальный элемент массива
void MinMax (double [] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
}



//Метод выводит сгенерированный массив
void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Задача со * - методы сортировки

/* int number = ReadData("Введите количество элементов в массиве: ");                                          // Пользователь задает количество элементов в массиве
int minValue = ReadData("Введите нижнюю границу массива: ");                                 // Пользователь задает нижний диапазон числа в массиве
int maxValue = ReadData("Введите верхнюю границу массива: ");                                // Пользователь задает верхний диапазон числа в массиве
int[] array = GenArray(number, minValue, maxValue);                                                         // Генерируем массив с заданными параметрами
Console.WriteLine();  
PrintData("Исходный массив: ");
PrintArray(array);                                                                                          // Выводим массив на печать
Console.WriteLine(); 

DateTime d1 = DateTime.Now;                                                                                 // Фиксируем текущее время
int[] arrayInsertSort = InsertSort(array);                                                                  // Сортируем массив методом вставки
Console.Write("Время работы сортировки методом вставки: ");
Console.WriteLine(DateTime.Now - d1);                                                                       // Определяем время работы метода

DateTime d2 = DateTime.Now;                                                                                 // Фиксируем текущее время
int[] arrayCountSort = CountSort(array, maxValue);                                                          // Сортируем массив методом подсчета
Console.Write("Время работы сортировки методом подсчета: ");
Console.WriteLine(DateTime.Now - d2);                                                                       // Определяем время работы метода

DateTime d3 = DateTime.Now;                                                                                 // Фиксируем текущее время
int[] arrayBableSort = BubbleSort(array);                                                                   // Сортируем массив методом пузырька
Console.Write("Время работы сортировки методом пузырька: ");
Console.WriteLine(DateTime.Now - d3);                                                                       // Определяем время работы метода

PrintData("");
PrintData("Массив, отсортированный методом вставки: ");
PrintArray(arrayInsertSort);
PrintData("Массив, отсортированный методом подсчета: ");
PrintArray(arrayCountSort);
PrintData("Массив, отсортированный методом пузырька: ");
PrintArray(arrayBableSort);
PrintData("");
PrintData("Разница между первым и последним элементом (метод вставки) равна: " + (arrayInsertSort[arrayInsertSort.Length - 1] - arrayInsertSort[0]));
PrintData("Разница между первым и последним элементом (метод подсчета) равна: " + (arrayCountSort[arrayCountSort.Length - 1] - arrayCountSort[0]));
PrintData("Разница между первым и последним элементом (метод пузырька) равна: " + (arrayBableSort[arrayBableSort.Length - 1] - arrayBableSort[0]));

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
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


// Сортировка методом вставки
int[] InsertSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i;
        while (j > 1 && array[j - 1] > key)
        {
            int temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
            j -= 1;
        }
        array[j] = key;
    }
    return array;
}

// Сортировка методом подсчета
int[] CountSort(int[] array, int maxValue)
{
    int[] count = new int[maxValue + 1];          // Создаем дополнительный массив, в котором будет храниться количество каждого числа в исходном массиве
    for (int i = 0; i < array.Length; i++)        // Считаем сколько раз каждое число встречается в исходном массиве
    {
        count[array[i]]++;
    }
    int index = 0;
    for (int i = 0; i < count.Length; i++)        // Переписываем исходный массив, используя данные нового массива
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index++;
        }
    }
    return array;
}

// Сортировка пузырьком
int[] BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {

            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
} */