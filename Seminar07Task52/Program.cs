// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Посчитать среднее арифметическое по диагоналям и вывести след значением в диагонали, диагонали печатаем одним цветом

// Задача решена для квадратной матрицы, над прямоугольной надо подумать)) 

//-------------- Тело программы--------------
int row = ReadData("Введите количество строк и столбцов: ");
int column = row; // ReadData("Введите количество столбцов: ");

// Генерируем массив
int[,] array = Fill2Array(row, column, 1, 99);
// Печатаем заданный массив
PrintData("Исходный массив");
Print2DArray(array, row, column);

// считаем среднее арифметические в крайей строке и крайнем ряду
CalcDiag(array);
// Печатаем массив плюс строка снизу и плюс строка справа
PrintData("Добавлены средние арифметические по диагонали");
Print2DArray(array, row + 1, column + 1);

//-----------------Методы--------------------------

// Метод подсчета среднего арифметического по диагоналям
void CalcDiag(int[,] arr)
{
    // перебираем крайний нижний ряд и крайний правый столбец, куда записаны суммы диагоналей
    // пропускаем элементы [n,0] и [0,n] (мы туда ничего не записывали), не трогаем [n,n]
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        //  Количество элементов в диагонали ( или длина диагонали)будет равно i
        arr[i, arr.GetLength(1) - 1] = arr[i, arr.GetLength(1) - 1] / i;
        arr[arr.GetLength(0) - 1, i] = arr[arr.GetLength(0) - 1, i] / i;
    }
    arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] = arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] / (arr.GetLength(0) - 1);
    return;
}

// Метод генерации массива
int[,] Fill2Array(int countRow, int countColumn, int minValue, int maxValue)
{
    System.Random rnd = new System.Random();
    // делаем по одному доп столбцу и доп строке для заполнения средними арифметическими
    int[,] array2D = new int[countRow + 1, countColumn + 1]; 
    for (int i = 0; i < array2D.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);

            // Заполняем дополнительный нижний ряд и правый столбец суммами по диагонали 
            // среднее арифметичиское посчитаем поздней отдельным методом                  
            if (i < j) array2D[countRow - (j - i), countColumn] += array2D[i, j];
            if (i > j) array2D[countRow, countColumn - (i - j)] += array2D[i, j];
            // главная диагональ считается отдельно
            if (i == j) array2D[countRow, countColumn] += array2D[i, j];
        }
    }
    return array2D;
}

//Метод  печати двумерного массива
void Print2DArray(int[,] matr, int printRow, int printColumn)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < printRow; i++)
    {
        for (int j = 0; j < printColumn; j++)
        {
            // при печати убираем элементы [n,0] и [0,n]
            if ((i == (matr.GetLength(0)-1) && j == 0) || (i == 0 && j == (matr.GetLength(1)-1)))
            {
                Console.Write(/*matr[i, j] +*/"      ".Substring(matr[i, j].ToString().Length));
            }
            else
            {
                Console.ForegroundColor = col[15 - Math.Abs(i - j)];
                Console.Write(matr[i, j] + "     ".Substring(matr[i, j].ToString().Length));
                Console.ResetColor();
            }
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