// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполняем массив числами Фибоначчи (Ограничимся 20 чисел, массив можем взять больше). если в массиве есть найденное число, подсвечиваем его другим цветом

// Вводим размеры матрицы
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

// Вводим индексы искомого элемента
int rowIndex = ReadData("Введите индекс строки искомого элемента: ");
int columnIndex = ReadData("Введите индекс столбца искомого элемента: ");

// Проверяем по индексам, что такой массив есть
if(( rowIndex<row )&&( columnIndex<column ))
{
    // Генерируем массив числами из ряда Фибоначчи
    int[,] array = Fill2FibArray(row, column, 20);

    // Печатаем заданный массив, при печати подсвечиваем искомый элемент другим цветом 
    PrintData("\nРандомный массив");
    Print2DArray(array, rowIndex, columnIndex);
}
else 
{
    PrintData("\nПоиск невозможен, неверный номер индекса");
}
//-------------- Методы ---------------

// Метод наполнения массива числами Фибоначчи
void FibArray(int[] arr)
{
    arr[0]=0;
    arr[1]=1;
    PrintData("Ряд Фибоначчи ");
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] += arr[i-1] + arr[i-2];
        Console.Write(arr[i] + " ");          
    }
    return;
}

// Метод генерации массива
int[,] Fill2FibArray(int countRow, int countColumn, int fibLeng)
{
    // Создаем одномерный массив с числами Фибоначчи 
    int[] fibonacciArr = new int[fibLeng];       
    FibArray(fibonacciArr);
    
    int[,] array2D = new int[countRow, countColumn];
    
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            // Наполняем двумерный массив случайными элементами массива Фибоначчи
            array2D[i, j] = fibonacciArr[new Random().Next(0, fibonacciArr.Length)];
        }
    }
    return array2D;
}

//Метод  печати двумерного массива
void Print2DArray(int[,] matr, int rowInd, int columnInd)
{
    // ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    //                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    //                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    //                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    //                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    //                                         ConsoleColor.Yellow};

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            // Проверяем i и j на соответствие искомым индексам, подсвечиваем другим цветом
            if(i==rowInd && j== columnInd)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(matr[i, j] + "      ".Substring(matr[i, j].ToString().Length));
                Console.ResetColor();
            }
            else 
            {
                Console.Write(matr[i, j] + "      ".Substring(matr[i, j].ToString().Length));
            }
        }
        Console.WriteLine();
    }
}

// Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}