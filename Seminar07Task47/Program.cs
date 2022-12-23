// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * Каждая цифра печатается разным цветом

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

// Генерируем массив
double[,] array = Fill2Array(row, column, 1, 99);
// Печатаем заданный массив
PrintData("Рандомный вещественный массив");
Print2DArray(array);

// Метод генерации массива
double[,] Fill2Array(int countRow, int countColumn, int minValue, int maxValue)
{
    System.Random rnd = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
        }
    }
    return array2D;
}

//Метод  печати двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            PrintColoredNumber(matr[i, j]);         // печатаем каждый элемент массива через вспомогательный метод
            Console.Write("       ".Substring(matr[i, j].ToString().Length));    // выравниваем пробелы
        }
        Console.WriteLine();
    }
}

// метод печати числа разными цветами (через перевод double в string)
void PrintColoredNumber(double num)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    string numberInString = num.ToString();                             // переводим число в строку
    for (int i = 0; i < numberInString.Length; i++)                     // печатаем строку посимвольно, меняя цвета
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(numberInString[i]);
        Console.ResetColor();
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