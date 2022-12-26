// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//-------------- Тело программы--------------

int rowOf01Matrix = ReadData("Введите количество строк в первой матрице: ");
int columnOf01Matrix = ReadData("Введите количество столбцов в первой матрице: ");
int rowOf02Matrix = ReadData("Введите количество строк во второй матрице: ");
int columnOf02Matrix = ReadData("Введите количество столбцов во второй матрице: ");

// Генерируем матрицы
int[,] matrix01 = Fill2Array(rowOf01Matrix, columnOf01Matrix, 1, 9);
int[,] matrix02 = Fill2Array(rowOf02Matrix, columnOf02Matrix, 1, 9);

// Проверяем, что количество столбцов в первой матрице равно количеству строк во втрой матрице. Иначе произведение невозможно
if (columnOf01Matrix == rowOf02Matrix)
{
    // Печатаем матрицы
    PrintData("\nПервая матрица");
    Print2DArray(matrix01);
    PrintData("\nВторая матрица");
    Print2DArray(matrix02);
    // Заводим матрицу под произведение
    int[,] resultMatrix = new int[rowOf01Matrix, columnOf02Matrix];
    // Считаем произведение в новую матрицу
    MultiplicateOfMatrix(matrix01, matrix02, resultMatrix);
    PrintData("\nИтоговая матрица");
    Print2DArray(resultMatrix);
}
else
{
    PrintData("\nОшибка, произведение матриц невозможно");
}
//---------------Методы----------------------------------

// Метод перемножения матриц
void MultiplicateOfMatrix(int[,] matr01, int[,] matr02, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            for (int k = 0; k < matr01.GetLength(1); k++)
            {
                resultMatr[i,j]+=matr01[i,k]*matr02[k,j];
            }   
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


