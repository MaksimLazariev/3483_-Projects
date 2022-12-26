// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//-------------- Тело программы--------------
int row = ReadData("Введите количество строк и столбцов: ");
int column = ReadData("Введите количество столбцов: ");

// Генерируем массив
int[,] array = Fill2Array(row, column, 1, 99);
// Печатаем заданный массив
PrintData("Исходный массив");
Print2DArray(array);

// Сортируем массив построчно
BubbleSort2DArray(array);

// Печатаем отсортированный массив
PrintData("\nСортированный массив");
Print2DArray(array);

// ----------------Методы---------------

// Метод сортировки пузырьком двумерного массива по строкам
void BubbleSort2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        BubbleSort(arr, i);
    }

}

// Метод сортировки пузырьком. Передаем номер строки, в которой делаем сортировку
void BubbleSort(int[,] arr, int row)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        bool checker = false;          // Переменная для проверки, был ли обмен значениями при проходе второго цикла
        for (int j = 0; j < arr.GetLength(1) - i - 1; j++)
        {
            if (arr[row, j] > arr[row, j + 1])         // Если элемент больше следующего, делаем обмен значениями  
            {
                temp = arr[row, j];               // обмен
                arr[row, j] = arr[row, j + 1];
                arr[row, j + 1] = temp;
                checker = true;                   // ставим значение, что был обмен
            }
        }
        if (!checker) break;                       // если не было обменов, то выходим из цикла For, сортировка окончена. 
    }
    return;
}

// Метод генерации массива
int[,] Fill2Array(int countRow, int countColumn, int minValue, int maxValue)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

//Метод  печати двумерного массива
void Print2DArray(int[,] matr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matr[i, j] % 16];
            Console.Write(matr[i, j] + "    ".Substring(matr[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод, считывающий данные, введенные пользователем
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
