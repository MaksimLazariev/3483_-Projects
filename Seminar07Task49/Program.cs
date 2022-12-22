// Задача №49 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");

// Генерируем массив
int[,] array = Fill2Array(row, column, 11, 99);
// Печатаем заданный массив
PrintData("Рандомный массив");
Print2DArray(array);

UpdateArray(array);
PrintData("\nИзмененный массив");
Print2DArray(array);


// Метод изменяет элементы с четными индексами на их квадраты
void UpdateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            arr[i,j] = arr[i,j]*arr[i,j];
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
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matr[i, j] + "     ".Substring(matr[i, j].ToString().Length));
            Console.ResetColor();
       } 
        Console.WriteLine();
    }  
}

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}