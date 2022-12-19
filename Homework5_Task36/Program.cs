// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// * Вывести пары чисел: значение - позиция 1, позиция 2

int number = ReadData("Введите количество элементов в массиве: ");                                          // Пользователь задает количество элементов в массиве
int minValue = ReadData("Введите нижнюю границу массива: ");                                 // Пользователь задает нижний диапазон числа в массиве
int maxValue = ReadData("Введите верхнюю границу массива: ");                                // Пользователь задает верхний диапазон числа в массиве
int[] array = GenArray(number, minValue, maxValue);                                                         // Генерируем массив с заданными параметрами
Console.WriteLine();                                                                                              // Печатаем пустую строку
PrintArray(array);                                                                                          // Выводим массив на печать
int result = SumOdd(array);
Console.WriteLine();                                                                             // Вызываем метод, находящий сумму элементов, стоящих на нечётных позициях
PrintData("Cуммa элементов, стоящих на нечётных позициях равна " + result);                                 // Печатаем результат
Console.WriteLine();
PrintData("Найденные пары в массиве:");
PairElem(array);                                                                                            // Вызываем метод, находящий пары в массиве и печатающий их пользователю

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

// Метод, находящий сумму элементов, стоящих на нечётных позициях
int SumOdd(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}

// Метод, добавляющий новый элемент в массив
int[] AddToArray(int[] array, int elem)
{
    int[] res = new int[array.Length + 1];    // Создаем новый массив с длиной на 1 больше исходного массива
    array.CopyTo(res, 0);                     // Копируем исходный массив в новый, начиная с нулевого индекса 
    res[res.Length - 1] = elem;               // На последнее место в новый массив вставляем необходимый элемент
    return res;
}

// Метод, находящий все пары в массиве и выводящий их пользователю
void PairElem(int[] array)
{
    int[] arrayIndex = new int[0];                                                             // Создаем массив нулевой длины, в который будем записывать индексы второго вхождения числа

    for (int i = 0; i < array.Length; i++)
    {
        if (!arrayIndex.Contains(i))                                                          // Проверяем, обрабатывали ли мы раньше этот индекс
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])                                                     // Условие на равенство двух элементов массива
                {
                    Console.WriteLine(array[i] + ": " + "[" + i + "," + j + "]");              // Выводим найденную пару на печать в консоль
                    arrayIndex = AddToArray(arrayIndex, j);                                   // В новый массив добавляем индекс второго элемента пары
                    break;                                                                    // Прерываем работу цикла, т.к. пара найдена
                }

            }
        }
    }

}
