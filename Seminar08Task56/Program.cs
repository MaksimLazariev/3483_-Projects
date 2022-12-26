// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//-------------- Тело программы--------------
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

// Генерируем массив
int[,] array = Fill2Array(row, column, 1, 99);
// Печатаем заданный массив
PrintData("\nИсходный массив");
Print2DArray(array);

// Заводим одномерный массив поколичеству строк.
int[] sumArray = new int[row];
// Заполняем массив суммами строк
FillRowSum(array, sumArray);
PrintData("\nСуммы элементов по строкам равны");
Print1DArr(sumArray);

int minIndex=SearchMinElement(sumArray);
PrintData($"\nСтрока {minIndex} с минимальной суммой элементов");

// ----------------Методы---------------

// Поиск минимального элемента массиве
int SearchMinElement(int[] arr)
{
    int index = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
return index;
}


//Метод  печати одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


// Метод нахождения суммы элемнтов в строке в двумерном массиве
void FillRowSum(int[,] matr, int[] arr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i] += matr[i, j];
        }
    }
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

